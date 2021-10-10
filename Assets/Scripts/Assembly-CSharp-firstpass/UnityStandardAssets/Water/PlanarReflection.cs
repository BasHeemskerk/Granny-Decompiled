using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		public LayerMask reflectionMask;

		public bool reflectSkybox;

		public Color clearColor = Color.grey;

		public string reflectionSampler = "_ReflectionTex";

		public float clipPlaneOffset = 0.07f;

		private Vector3 m_Oldpos;

		private Camera m_ReflectionCamera;

		private Material m_SharedMaterial;

		private Dictionary<Camera, bool> m_HelperCameras;

		public void Start()
		{
			m_SharedMaterial = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		private Camera CreateReflectionCameraFor(Camera cam)
		{
			string text = base.gameObject.name + "Reflection" + cam.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				gameObject = new GameObject(text, typeof(Camera));
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = clearColor;
			component.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			SetStandardCameraParameter(component, reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = CreateTextureFor(cam);
			}
			return component;
		}

		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
			cam.cullingMask = (int)mask & ~(1 << LayerMask.NameToLayer("Water"));
			cam.backgroundColor = Color.black;
			cam.enabled = false;
		}

		private RenderTexture CreateTextureFor(Camera cam)
		{
			RenderTexture renderTexture = new RenderTexture(Mathf.FloorToInt((float)cam.pixelWidth * 0.5f), Mathf.FloorToInt((float)cam.pixelHeight * 0.5f), 24);
			renderTexture.hideFlags = HideFlags.DontSave;
			return renderTexture;
		}

		public void RenderHelpCameras(Camera currentCam)
		{
			if (m_HelperCameras == null)
			{
				m_HelperCameras = new Dictionary<Camera, bool>();
			}
			if (!m_HelperCameras.ContainsKey(currentCam))
			{
				m_HelperCameras.Add(currentCam, false);
			}
			if (!m_HelperCameras[currentCam])
			{
				if (!m_ReflectionCamera)
				{
					m_ReflectionCamera = CreateReflectionCameraFor(currentCam);
				}
				RenderReflectionFor(currentCam, m_ReflectionCamera);
				m_HelperCameras[currentCam] = true;
			}
		}

		public void LateUpdate()
		{
			if (m_HelperCameras != null)
			{
				m_HelperCameras.Clear();
			}
		}

		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			RenderHelpCameras(currentCam);
			if ((bool)m_ReflectionCamera && (bool)m_SharedMaterial)
			{
				m_SharedMaterial.SetTexture(reflectionSampler, m_ReflectionCamera.targetTexture);
			}
		}

		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_SIMPLE");
		}

		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
		}

		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
			if (!reflectCamera || ((bool)m_SharedMaterial && !m_SharedMaterial.HasProperty(reflectionSampler)))
			{
				return;
			}
			reflectCamera.cullingMask = (int)reflectionMask & ~(1 << LayerMask.NameToLayer("Water"));
			SaneCameraSettings(reflectCamera);
			reflectCamera.backgroundColor = clearColor;
			reflectCamera.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			if (reflectSkybox && (bool)cam.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)reflectCamera.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)reflectCamera.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)cam.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
			reflectCamera.transform.position = cam.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
			Vector4 plane = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 zero = Matrix4x4.zero;
			zero = CalculateReflectionMatrix(zero, plane);
			m_Oldpos = cam.transform.position;
			Vector3 position2 = zero.MultiplyPoint(m_Oldpos);
			reflectCamera.worldToCameraMatrix = cam.worldToCameraMatrix * zero;
			Vector4 clipPlane = CameraSpacePlane(reflectCamera, position, up, 1f);
			Matrix4x4 projectionMatrix = cam.projectionMatrix;
			projectionMatrix = (reflectCamera.projectionMatrix = CalculateObliqueMatrix(projectionMatrix, clipPlane));
			reflectCamera.transform.position = position2;
			Vector3 eulerAngles2 = cam.transform.eulerAngles;
			reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			reflectCamera.Render();
			GL.invertCulling = false;
		}

		private void SaneCameraSettings(Camera helperCam)
		{
			helperCam.depthTextureMode = DepthTextureMode.None;
			helperCam.backgroundColor = Color.black;
			helperCam.clearFlags = CameraClearFlags.Color;
			helperCam.renderingPath = RenderingPath.Forward;
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			Vector4 b = projection.inverse * new Vector4(Sgn(clipPlane.x), Sgn(clipPlane.y), 1f, 1f);
			Vector4 vector = clipPlane * (2f / Vector4.Dot(clipPlane, b));
			projection[2] = vector.x - projection[3];
			projection[6] = vector.y - projection[7];
			projection[10] = vector.z - projection[11];
			projection[14] = vector.w - projection[15];
			return projection;
		}

		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
			reflectionMat.m01 = -2f * plane[0] * plane[1];
			reflectionMat.m02 = -2f * plane[0] * plane[2];
			reflectionMat.m03 = -2f * plane[3] * plane[0];
			reflectionMat.m10 = -2f * plane[1] * plane[0];
			reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
			reflectionMat.m12 = -2f * plane[1] * plane[2];
			reflectionMat.m13 = -2f * plane[3] * plane[1];
			reflectionMat.m20 = -2f * plane[2] * plane[0];
			reflectionMat.m21 = -2f * plane[2] * plane[1];
			reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
			reflectionMat.m23 = -2f * plane[3] * plane[2];
			reflectionMat.m30 = 0f;
			reflectionMat.m31 = 0f;
			reflectionMat.m32 = 0f;
			reflectionMat.m33 = 1f;
			return reflectionMat;
		}

		private static float Sgn(float a)
		{
			if (a > 0f)
			{
				return 1f;
			}
			if (a < 0f)
			{
				return -1f;
			}
			return 0f;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			Vector3 point = pos + normal * clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
			return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
		}
	}
}

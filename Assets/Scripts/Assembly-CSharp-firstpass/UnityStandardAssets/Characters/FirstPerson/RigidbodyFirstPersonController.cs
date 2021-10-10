using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		public class MovementSettings
		{
			public float ForwardSpeed = 8f;

			public float BackwardSpeed = 4f;

			public float StrafeSpeed = 4f;

			public float RunMultiplier = 2f;

			public KeyCode RunKey = KeyCode.LeftShift;

			public float JumpForce = 30f;

			public AnimationCurve SlopeCurveModifier = new AnimationCurve(new Keyframe(-90f, 1f), new Keyframe(0f, 1f), new Keyframe(90f, 0f));

			[HideInInspector]
			public float CurrentTargetSpeed = 8f;

			private bool m_Running;

			public bool Running
			{
				get
				{
					return m_Running;
				}
			}

			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
				if (!(input == Vector2.zero))
				{
					if (input.x > 0f || input.x < 0f)
					{
						CurrentTargetSpeed = StrafeSpeed;
					}
					if (input.y < 0f)
					{
						CurrentTargetSpeed = BackwardSpeed;
					}
					if (input.y > 0f)
					{
						CurrentTargetSpeed = ForwardSpeed;
					}
					if (Input.GetKey(RunKey))
					{
						CurrentTargetSpeed *= RunMultiplier;
						m_Running = true;
					}
					else
					{
						m_Running = false;
					}
				}
			}
		}

		[Serializable]
		public class AdvancedSettings
		{
			public float groundCheckDistance = 0.01f;

			public float stickToGroundHelperDistance = 0.5f;

			public float slowDownRate = 20f;

			public bool airControl;

			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;
		}

		public Camera cam;

		public MovementSettings movementSettings = new MovementSettings();

		public MouseLook mouseLook = new MouseLook();

		public AdvancedSettings advancedSettings = new AdvancedSettings();

		private Rigidbody m_RigidBody;

		private CapsuleCollider m_Capsule;

		private float m_YRotation;

		private Vector3 m_GroundContactNormal;

		private bool m_Jump;

		private bool m_PreviouslyGrounded;

		private bool m_Jumping;

		private bool m_IsGrounded;

		public Vector3 Velocity
		{
			get
			{
				return m_RigidBody.velocity;
			}
		}

		public bool Grounded
		{
			get
			{
				return m_IsGrounded;
			}
		}

		public bool Jumping
		{
			get
			{
				return m_Jumping;
			}
		}

		public bool Running
		{
			get
			{
				return movementSettings.Running;
			}
		}

		private void Start()
		{
			m_RigidBody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			mouseLook.Init(base.transform, cam.transform);
		}

		private void Update()
		{
			RotateView();
			if (CrossPlatformInputManager.GetButtonDown("Jump") && !m_Jump)
			{
				m_Jump = true;
			}
		}

		private void FixedUpdate()
		{
			GroundCheck();
			Vector2 input = GetInput();
			if ((Mathf.Abs(input.x) > float.Epsilon || Mathf.Abs(input.y) > float.Epsilon) && (advancedSettings.airControl || m_IsGrounded))
			{
				Vector3 vector = cam.transform.forward * input.y + cam.transform.right * input.x;
				vector = Vector3.ProjectOnPlane(vector, m_GroundContactNormal).normalized;
				vector.x *= movementSettings.CurrentTargetSpeed;
				vector.z *= movementSettings.CurrentTargetSpeed;
				vector.y *= movementSettings.CurrentTargetSpeed;
				if (m_RigidBody.velocity.sqrMagnitude < movementSettings.CurrentTargetSpeed * movementSettings.CurrentTargetSpeed)
				{
					m_RigidBody.AddForce(vector * SlopeMultiplier(), ForceMode.Impulse);
				}
			}
			if (m_IsGrounded)
			{
				m_RigidBody.drag = 5f;
				if (m_Jump)
				{
					m_RigidBody.drag = 0f;
					m_RigidBody.velocity = new Vector3(m_RigidBody.velocity.x, 0f, m_RigidBody.velocity.z);
					m_RigidBody.AddForce(new Vector3(0f, movementSettings.JumpForce, 0f), ForceMode.Impulse);
					m_Jumping = true;
				}
				if (!m_Jumping && Mathf.Abs(input.x) < float.Epsilon && Mathf.Abs(input.y) < float.Epsilon && m_RigidBody.velocity.magnitude < 1f)
				{
					m_RigidBody.Sleep();
				}
			}
			else
			{
				m_RigidBody.drag = 0f;
				if (m_PreviouslyGrounded && !m_Jumping)
				{
					StickToGroundHelper();
				}
			}
			m_Jump = false;
		}

		private float SlopeMultiplier()
		{
			float time = Vector3.Angle(m_GroundContactNormal, Vector3.up);
			return movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		private void StickToGroundHelper()
		{
			RaycastHit hitInfo;
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.stickToGroundHelperDistance, -1, QueryTriggerInteraction.Ignore) && Mathf.Abs(Vector3.Angle(hitInfo.normal, Vector3.up)) < 85f)
			{
				m_RigidBody.velocity = Vector3.ProjectOnPlane(m_RigidBody.velocity, hitInfo.normal);
			}
		}

		private Vector2 GetInput()
		{
			Vector2 vector = default(Vector2);
			vector.x = CrossPlatformInputManager.GetAxis("Horizontal");
			vector.y = CrossPlatformInputManager.GetAxis("Vertical");
			Vector2 vector2 = vector;
			movementSettings.UpdateDesiredTargetSpeed(vector2);
			return vector2;
		}

		private void RotateView()
		{
			if (!(Mathf.Abs(Time.timeScale) < float.Epsilon))
			{
				float y = base.transform.eulerAngles.y;
				mouseLook.LookRotation(base.transform, cam.transform);
				if (m_IsGrounded || advancedSettings.airControl)
				{
					Quaternion quaternion = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
					m_RigidBody.velocity = quaternion * m_RigidBody.velocity;
				}
			}
		}

		private void GroundCheck()
		{
			m_PreviouslyGrounded = m_IsGrounded;
			RaycastHit hitInfo;
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.groundCheckDistance, -1, QueryTriggerInteraction.Ignore))
			{
				m_IsGrounded = true;
				m_GroundContactNormal = hitInfo.normal;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundContactNormal = Vector3.up;
			}
			if (!m_PreviouslyGrounded && m_IsGrounded && m_Jumping)
			{
				m_Jumping = false;
			}
		}
	}
}

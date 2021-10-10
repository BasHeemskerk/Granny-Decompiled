using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController_Egen : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		public float m_WalkSpeed;

		[SerializeField]
		private float m_RunSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[SerializeField]
		private float m_JumpSpeed;

		[SerializeField]
		private float m_StickToGroundForce;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private MouseLook m_MouseLook;

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVKick m_FovKick = new FOVKick();

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveControlledBob m_HeadBob = new CurveControlledBob();

		[SerializeField]
		private LerpControlledBob m_JumpBob = new LerpControlledBob();

		[SerializeField]
		private float m_StepInterval;

		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[SerializeField]
		private AudioClip m_JumpSound;

		[SerializeField]
		private AudioClip m_LandSound;

		public Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private Vector2 m_Input;

		private Vector3 m_MoveDir = Vector3.zero;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private AudioSource m_AudioSource;

		public GameObject checkGround;

		public GameObject footstepScriptHolder;

		public bool day2;

		public bool day3;

		public GameObject headBobAnimHolder;

		public GameObject crouchHolder;

		public bool playerGetCaught;

		public GameObject doorScriptHolder;

		public bool fallTimerStarted;

		public float timeInAir;

		public GameObject soundHolder;

		public GameObject granny;

		public GameObject Player;

		public bool PlayerIsGrounded;

		public GameObject FallsoundHolder;

		public bool playerInhole;

		public GameObject inGameOptionMenu;

		public bool menuEnabled;

		public float mouseSens;

		private void Start()
		{
			m_CharacterController = GetComponent<CharacterController>();
			m_OriginalCameraPosition = m_Camera.transform.localPosition;
			m_StepCycle = 0f;
			m_NextStep = m_StepCycle / 2f;
			m_Jumping = false;
			m_AudioSource = GetComponent<AudioSource>();
			m_MouseLook.Init(base.transform, m_Camera.transform);
			footstepScriptHolder = GameObject.Find("CameraPivot");
			timeInAir = 0f;
			playerInhole = false;
		}

		private void Update()
		{
			RotateView();
			if (!m_PreviouslyGrounded && m_CharacterController.isGrounded)
			{
				StartCoroutine(m_JumpBob.DoBobCycle());
				m_MoveDir.y = 0f;
				m_Jumping = false;
			}
			if (!m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded)
			{
				m_MoveDir.y = 0f;
			}
			m_PreviouslyGrounded = m_CharacterController.isGrounded;
			if (!playerGetCaught)
			{
				if (!menuEnabled && Input.GetKeyDown(KeyCode.C) && !playerInhole)
				{
					((playerCrawl)crouchHolder.GetComponent(typeof(playerCrawl))).crouching();
				}
				if (Input.GetKeyDown(KeyCode.Escape) && !menuEnabled)
				{
					inGameOptionMenu.SetActive(true);
					Time.timeScale = 0f;
					Cursor.visible = true;
					Screen.lockCursor = false;
					menuEnabled = true;
				}
			}
		}

		private void PlayLandingSound()
		{
			m_AudioSource.clip = m_LandSound;
			m_AudioSource.Play();
			m_NextStep = m_StepCycle + 0.5f;
		}

		private void FixedUpdate()
		{
			float speed;
			GetInput(out speed);
			Vector3 vector = base.transform.forward * m_Input.y + base.transform.right * m_Input.x;
			RaycastHit hitInfo;
			Physics.SphereCast(base.transform.position, m_CharacterController.radius, Vector3.down, out hitInfo, m_CharacterController.height / 2f, -1, QueryTriggerInteraction.Ignore);
			vector = Vector3.ProjectOnPlane(vector, hitInfo.normal).normalized;
			m_MoveDir.x = vector.x * speed;
			m_MoveDir.z = vector.z * speed;
			if (PlayerPrefs.GetFloat("MouseSens") != 0f)
			{
				m_MouseLook.XSensitivity = PlayerPrefs.GetFloat("MouseSens", 0f);
				m_MouseLook.YSensitivity = PlayerPrefs.GetFloat("MouseSens", 0f);
			}
			else
			{
				m_MouseLook.XSensitivity = 2f;
				m_MouseLook.YSensitivity = 2f;
			}
			if (m_CharacterController.isGrounded)
			{
				m_MoveDir.y = 0f - m_StickToGroundForce;
				PlayerIsGrounded = true;
				((playerFallingSound)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFallingNot();
				if (timeInAir > 0.5f)
				{
					timeInAir = 0f;
					fallTimerStarted = false;
					((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).playerLandSound();
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
					((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
					StartCoroutine(((playerCaught)Player.GetComponent(typeof(playerCaught))).fallingDead());
					m_WalkSpeed = 0f;
				}
			}
			else
			{
				m_MoveDir += Physics.gravity * m_GravityMultiplier * Time.fixedDeltaTime;
				PlayerIsGrounded = false;
				if (fallTimerStarted)
				{
					timeInAir += Time.deltaTime;
					((playerFallingSound)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFalling();
				}
			}
			m_CollisionFlags = m_CharacterController.Move(m_MoveDir * Time.fixedDeltaTime);
			ProgressStepCycle(speed);
			UpdateCameraPosition(speed);
			m_MouseLook.UpdateCursorLock();
		}

		private void PlayJumpSound()
		{
			m_AudioSource.clip = m_JumpSound;
			m_AudioSource.Play();
		}

		private void ProgressStepCycle(float speed)
		{
			RaycastHit hitInfo = default(RaycastHit);
			if (m_CharacterController.velocity.sqrMagnitude > 0f && (m_Input.x != 0f || m_Input.y != 0f))
			{
				m_StepCycle += (m_CharacterController.velocity.magnitude + speed * ((!m_IsWalking) ? m_RunstepLenghten : 1f)) * Time.fixedDeltaTime;
				GameObject.Find("CameraPivot").GetComponent<Footsteps>().walk();
				m_IsWalking = true;
			}
			else
			{
				GameObject.Find("CameraPivot").GetComponent<Footsteps>().stopwalk();
				m_IsWalking = false;
			}
			if (!(m_StepCycle > m_NextStep))
			{
				return;
			}
			m_NextStep = m_StepCycle + m_StepInterval;
			Vector3 vector = new Vector3(0f, -1f, 0f);
			if (Physics.Raycast(checkGround.transform.position, vector, out hitInfo, 5f))
			{
				Debug.DrawRay(checkGround.transform.position, vector, Color.yellow);
				if (hitInfo.collider.gameObject.tag == "grus")
				{
					GameObject.Find("CameraPivot").GetComponent<Footsteps>().walkGrus = true;
				}
				if (hitInfo.collider.gameObject.tag == "golv")
				{
					GameObject.Find("CameraPivot").GetComponent<Footsteps>().walkGrus = false;
				}
			}
		}

		private void PlayFootStepAudio()
		{
			if (m_CharacterController.isGrounded)
			{
				int num = Random.Range(1, m_FootstepSounds.Length);
				m_AudioSource.clip = m_FootstepSounds[num];
				m_AudioSource.PlayOneShot(m_AudioSource.clip);
				m_FootstepSounds[num] = m_FootstepSounds[0];
				m_FootstepSounds[0] = m_AudioSource.clip;
			}
		}

		private void UpdateCameraPosition(float speed)
		{
			if (m_UseHeadBob)
			{
				Vector3 localPosition;
				if (m_CharacterController.velocity.magnitude > 0f && m_CharacterController.isGrounded)
				{
					m_Camera.transform.localPosition = m_HeadBob.DoHeadBob(m_CharacterController.velocity.magnitude + speed * ((!m_IsWalking) ? m_RunstepLenghten : 1f));
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_Camera.transform.localPosition.y - m_JumpBob.Offset();
				}
				else
				{
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_OriginalCameraPosition.y - m_JumpBob.Offset();
				}
				m_Camera.transform.localPosition = localPosition;
			}
		}

		private void GetInput(out float speed)
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			bool isWalking = m_IsWalking;
			m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
			speed = ((!m_IsWalking) ? m_RunSpeed : m_WalkSpeed);
			m_Input = new Vector2(axis, axis2);
			if (m_Input.sqrMagnitude > 1f)
			{
				m_Input.Normalize();
			}
			if (m_IsWalking != isWalking && m_UseFovKick && m_CharacterController.velocity.sqrMagnitude > 0f)
			{
				StopAllCoroutines();
				StartCoroutine(m_IsWalking ? m_FovKick.FOVKickDown() : m_FovKick.FOVKickUp());
			}
		}

		public void resetMouse()
		{
			m_MouseLook.Init(base.transform, m_Camera.transform);
		}

		private void RotateView()
		{
			if (!menuEnabled && !playerGetCaught)
			{
				m_MouseLook.LookRotation(base.transform, m_Camera.transform);
			}
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			Rigidbody attachedRigidbody = hit.collider.attachedRigidbody;
			if (m_CollisionFlags != CollisionFlags.Below && !(attachedRigidbody == null) && !attachedRigidbody.isKinematic)
			{
				attachedRigidbody.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
			}
		}
	}
}

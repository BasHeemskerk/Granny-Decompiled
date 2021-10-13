using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[SerializeField]
		private float m_MovingTurnSpeed = 360f;

		[SerializeField]
		private float m_StationaryTurnSpeed = 180f;

		[SerializeField]
		private float m_JumpPower = 12f;

		[Range(1f, 4f)]
		[SerializeField]
		private float m_GravityMultiplier = 2f;

		[SerializeField]
		private float m_RunCycleLegOffset = 0.2f;

		[SerializeField]
		private float m_MoveSpeedMultiplier = 1f;

		[SerializeField]
		private float m_AnimSpeedMultiplier = 1f;

		[SerializeField]
		private float m_GroundCheckDistance = 0.1f;

		private Rigidbody m_Rigidbody;

		private Animator m_Animator;

		private bool m_IsGrounded;

		private float m_OrigGroundCheckDistance;

		private const float k_Half = 0.5f;

		private float m_TurnAmount;

		private float m_ForwardAmount;

		private Vector3 m_GroundNormal;

		private float m_CapsuleHeight;

		private Vector3 m_CapsuleCenter;

		private CapsuleCollider m_Capsule;

		private bool m_Crouching;

		private void Start()
		{
			m_Animator = GetComponent<Animator>();
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			m_CapsuleHeight = m_Capsule.height;
			m_CapsuleCenter = m_Capsule.center;
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
			m_OrigGroundCheckDistance = m_GroundCheckDistance;
		}

		public void Move(Vector3 move, bool crouch, bool jump)
		{
			if (move.magnitude > 1f)
			{
				move.Normalize();
			}
			move = base.transform.InverseTransformDirection(move);
			CheckGroundStatus();
			move = Vector3.ProjectOnPlane(move, m_GroundNormal);
			m_TurnAmount = Mathf.Atan2(move.x, move.z);
			m_ForwardAmount = move.z;
			ApplyExtraTurnRotation();
			if (m_IsGrounded)
			{
				HandleGroundedMovement(crouch, jump);
			}
			else
			{
				HandleAirborneMovement();
			}
			ScaleCapsuleForCrouching(crouch);
			PreventStandingInLowHeadroom();
			UpdateAnimator(move);
		}

		private void ScaleCapsuleForCrouching(bool crouch)
		{
			if (m_IsGrounded && crouch)
			{
				if (!m_Crouching)
				{
					m_Capsule.height /= 2f;
					m_Capsule.center /= 2f;
					m_Crouching = true;
				}
				return;
			}
			Ray ray = new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up);
			float maxDistance = m_CapsuleHeight - m_Capsule.radius * 0.5f;
			if (Physics.SphereCast(ray, m_Capsule.radius * 0.5f, maxDistance, -1, QueryTriggerInteraction.Ignore))
			{
				m_Crouching = true;
				return;
			}
			m_Capsule.height = m_CapsuleHeight;
			m_Capsule.center = m_CapsuleCenter;
			m_Crouching = false;
		}

		private void PreventStandingInLowHeadroom()
		{
			if (!m_Crouching)
			{
				Ray ray = new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up);
				float maxDistance = m_CapsuleHeight - m_Capsule.radius * 0.5f;
				if (Physics.SphereCast(ray, m_Capsule.radius * 0.5f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					m_Crouching = true;
				}
			}
		}

		private void UpdateAnimator(Vector3 move)
		{
			m_Animator.SetFloat("Forward", m_ForwardAmount, 0.1f, Time.deltaTime);
			m_Animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
			m_Animator.SetBool("Crouch", m_Crouching);
			m_Animator.SetBool("OnGround", m_IsGrounded);
			if (!m_IsGrounded)
			{
				m_Animator.SetFloat("Jump", m_Rigidbody.velocity.y);
			}
			float num = Mathf.Repeat(m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime + m_RunCycleLegOffset, 1f);
			float value = (float)((num < 0.5f) ? 1 : (-1)) * m_ForwardAmount;
			if (m_IsGrounded)
			{
				m_Animator.SetFloat("JumpLeg", value);
			}
			if (m_IsGrounded && move.magnitude > 0f)
			{
				m_Animator.speed = m_AnimSpeedMultiplier;
			}
			else
			{
				m_Animator.speed = 1f;
			}
		}

		private void HandleAirborneMovement()
		{
			Vector3 force = Physics.gravity * m_GravityMultiplier - Physics.gravity;
			m_Rigidbody.AddForce(force);
			m_GroundCheckDistance = ((!(m_Rigidbody.velocity.y < 0f)) ? 0.01f : m_OrigGroundCheckDistance);
		}

		private void HandleGroundedMovement(bool crouch, bool jump)
		{
			if (jump && !crouch && m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
			{
				m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_JumpPower, m_Rigidbody.velocity.z);
				m_IsGrounded = false;
				m_Animator.applyRootMotion = false;
				m_GroundCheckDistance = 0.1f;
			}
		}

		private void ApplyExtraTurnRotation()
		{
			float num = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, m_ForwardAmount);
			base.transform.Rotate(0f, m_TurnAmount * num * Time.deltaTime, 0f);
		}

		public void OnAnimatorMove()
		{
			if (m_IsGrounded && Time.deltaTime > 0f)
			{
				Vector3 velocity = m_Animator.deltaPosition * m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = m_Rigidbody.velocity.y;
				m_Rigidbody.velocity = velocity;
			}
		}

		private void CheckGroundStatus()
		{
			RaycastHit hitInfo;
			if (Physics.Raycast(base.transform.position + Vector3.up * 0.1f, Vector3.down, out hitInfo, m_GroundCheckDistance))
			{
				m_GroundNormal = hitInfo.normal;
				m_IsGrounded = true;
				m_Animator.applyRootMotion = true;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundNormal = Vector3.up;
				m_Animator.applyRootMotion = false;
			}
		}
	}
}

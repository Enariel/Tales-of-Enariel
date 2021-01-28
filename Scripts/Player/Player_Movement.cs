//Copyright (c) FuchsFarbe

using UnityEngine;

/* ============================================
*               Player Movement
* --------------------------------------------
*		Controls the movement of the player
*	and gets input from the player controller.
*  ===========================================
*/

//TODO MODIFY THIS SCRIPT TO USE MOUSE MOVEMENT AND NAV_MESH AGENTS

namespace Tales_Of_Enariel
{
	public class Player_Movement : MonoBehaviour
	{
		#region Variables

		//References
		private Player_Controller pc;
		private Camera mainCamera;
		//Variables
		private const float GRAVITY = -9.81f;

		[SerializeField] private bool isRunning;
		[SerializeField] private bool isGrounded;
		[SerializeField] private float baseSpeed;
		[SerializeField] private float playerWalkSpeed;
		[SerializeField] private float runningSpeed;
		[SerializeField] private float jumpHeight;
		[SerializeField] private float turnSmoothVelocity = 0.1f, turnSmoothTime = 0.1f, turnTime = .1f;
		[SerializeField] private float groundCheckRadius;
		[SerializeField] private LayerMask groundLayer;
		[SerializeField] private Vector3 direction;
		[SerializeField] private Vector3 gVelocity;
		[SerializeField] private Vector3 groundCheckOffset;
		[SerializeField] private Vector3 moveDir;
		[SerializeField] private float currentTimer, baseTime;

		//Properties
		public float PlayerWalkSpeed { get => baseSpeed; }
		public Vector3 PlayerVelocity { get => pc.PlayerCharacterController.velocity; }

		#endregion

		#region Unity Methods
		//Get components
		private void Awake()
		{
			pc = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
			mainCamera = Camera.main;
		}

		private void Update()
		{
			//Revert change and direction
			pc.Change = Vector2.zero;
			direction = Vector3.zero;

			//Move player
			MovePlayer();

			Debug.Log(pc.Change);
		}

		public void OnDrawGizmos()
		{
			Gizmos.DrawWireSphere(transform.position + groundCheckOffset, groundCheckRadius);
		} 
		#endregion

		private void DoGravity()
		{
			isGrounded = Physics.CheckSphere(transform.position + groundCheckOffset, groundCheckRadius, groundLayer);

			if (isGrounded && gVelocity.y < 0)
			{
				gVelocity.y = -2f;
			}
			//Multiplied times Time.deltaTime twice to square the gravity.
			gVelocity.y += GRAVITY * Time.deltaTime;
			pc.PlayerCharacterController.Move(gVelocity * Time.deltaTime);
		}

		private void Jump(bool canJump = false)
		{
			if (isGrounded && canJump)
			{
				gVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * GRAVITY);
			}
		}

		private void MovePlayer()
		{
			//Get input delta
			pc.Change = pc.MoveInput.ReadValue<Vector2>();
			//The desired direction the character should face
			direction = new Vector3(pc.Change.x, 0f, pc.Change.y);
			moveDir = direction;
			//Normalize values to find magnitude
			direction.Normalize();

			if (direction != Vector3.zero)
			{
				currentTimer = baseTime;
				//Some magic angle math I'm too small-brained to understand
				//Thank you brackeys for this
				//Basically this gets the camera angle and heading and bases player movement off that.
				float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;
				float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

				//Rotate only the player, not the Player_Controller
				transform.rotation = Quaternion.Euler(0f, angle, 0f);
				//Set forward move direction
				moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
				
			}
			else
			{
				currentTimer -= Time.deltaTime;

				if (currentTimer < 0f)
				{
					currentTimer = 0f;
				}
				if (currentTimer <= 0f)
				{
					//Rotation after 10s
					var targetRotation = Quaternion.Euler(0f, -180f, 0f);
					transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnTime);
				}
				//Slow movement to stop over time
				if (pc.PlayerCharacterController.velocity != Vector3.zero)
				{
					moveDir.x = PlayerVelocity.x * -Time.deltaTime;
					moveDir.y = PlayerVelocity.y * -Time.deltaTime;
				}
			}

			Jump();
			pc.PlayerCharacterController.Move(moveDir * PlayerWalkSpeed * direction.magnitude * Time.deltaTime);
			DoGravity();
		}
	}
}
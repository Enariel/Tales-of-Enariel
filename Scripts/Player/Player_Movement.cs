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
		//Serialized fields
		[SerializeField] private float baseSpeed;
		private float playerWalkSpeed;
		[SerializeField] private float runningSpeed;
		[SerializeField] private float turnSmoothVelocity = 0.1f, turnSmoothTime = 0.1f;
		[SerializeField] private bool isRunning = false;
		private Vector3 direction;

		//Properties
		public float PlayerWalkSpeed 
		{
			get
			{
				if (pc.RunInput.ReadValue<float>() > 0.1f)
				{
					if (playerWalkSpeed == runningSpeed)
					{
						return runningSpeed;
					}
					else if (playerWalkSpeed < runningSpeed)
					{
						return playerWalkSpeed += Time.deltaTime;
					}
				}
				else if (pc.RunInput.ReadValue<float>() < 0.1f)
				{
					if (playerWalkSpeed == baseSpeed)
					{
						return baseSpeed;
					}
					else if (playerWalkSpeed < baseSpeed)
					{
						return playerWalkSpeed += Time.deltaTime;
					}
				}
				return playerWalkSpeed = baseSpeed;
			} 
		}

		#endregion

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

		private void MovePlayer()
		{
			//Get input delta
			pc.Change = pc.MoveInput.ReadValue<Vector2>();
			//The desired direction the character should face
			direction = new Vector3(pc.Change.x, 0f, pc.Change.y);
			//Normalize values to find magnitude
			direction.Normalize();

			if (direction != Vector3.zero)
			{
				//Some magic angle math I'm too small-brained to understand
				//Thank you brackeys for this
				//Basically this gets the camera angle and heading and bases player movement off that.
				float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;
				float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

				//Rotate only the player, not the Player_Controller
				transform.rotation = Quaternion.Euler(0f, angle, 0f);
				//Set forward move direction
				Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
				pc.PlayerCharacterController.Move(moveDir * PlayerWalkSpeed * direction.magnitude * Time.deltaTime);
			}
		}
	}
}
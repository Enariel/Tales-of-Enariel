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
		//Variables
		//Serialized fields
		[SerializeField] private float baseSpeed;
		private float playerWalkSpeed;
		[SerializeField] private float runningSpeed;
		[SerializeField] private float playerZed = -2f;
		[SerializeField] private float turnSmoothVelocity = 0.1f, turnSmoothTime = 0.1f;
		[SerializeField] private bool isRunning = false;

		private Vector3 direction;

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
			pc = GameObject.FindGameObjectWithTag("GameController").GetComponent<Player_Controller>();
		}

		private void Update()
		{
			//Ensures that the players zed axis stays at -2
			if (pc.PlayerBody.transform.position.z != playerZed)
			{
				pc.PlayerBody.transform.position = new Vector3(0f, 0f, playerZed);
			}
			//Revert change and direction
			pc.Change = Vector2.zero;
			direction = Vector3.zero;
			//Move player
			MovePlayer();
		}

		private void MovePlayer()
		{
			//Check if change is changed with input
			pc.Change = pc.MoveInput.ReadValue<Vector2>();
			direction = new Vector3(pc.Change.x, 0f, pc.Change.y);

			direction.Normalize();

			if (pc.Change != Vector2.zero)
			{
				//Find angles to rotate players
				float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
				float angle = Mathf.SmoothDampAngle(pc.PlayerBody.transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
				//Rotate player in correct direction
				pc.PlayerBody.transform.rotation = Quaternion.Euler(0f, angle, 0f);

				//Move player
				pc.PlayerBody.transform.position = new Vector3(pc.PlayerBody.transform.position.x + pc.Change.x * PlayerWalkSpeed * Time.deltaTime, playerZed, pc.PlayerBody.transform.position.y + pc.Change.y * PlayerWalkSpeed * Time.deltaTime);
			}
		}
	}
}
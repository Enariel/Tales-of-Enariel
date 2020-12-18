//Copyright (c) FuchsFarbe

using System;
using UnityEngine;
using UnityEngine.InputSystem;
/* ============================================
*               Player_Controller
* --------------------------------------------
*       Controls player input and world 
*   movement and interaction.
*  ===========================================
*/
namespace Tales_Of_Enariel
{
    public class Player_Controller : MonoBehaviour
    {
		#region Variables
		//Input
		private Controls inputActions;

		private InputAction moveInput;
		private InputAction runInput;
		//References
		[SerializeField] private Rigidbody2D playerBody;
        //Variables
        [SerializeField] private float playerWalkSpeed;
        [SerializeField] private bool isRunning = false;
		[SerializeField] private Vector3 direction;
		[SerializeField] private float playerZed = -2f;
		[SerializeField] private float turnSmoothVelocity = 0.1f, turnSmoothTime = 0.1f;

		private Vector2 change = new Vector2(0f, 0f);
		#endregion

		#region Unity Methods
		private void Awake()
		{
			//Generate player input
			if (inputActions == null)
			{
				inputActions = new Controls();
			}
			moveInput = inputActions.Movement.Walk;
			runInput = inputActions.Movement.Run;

			//Apply callbacks
		}

		private void Start()
		{
			//Get player rigidbody
			playerBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
		}

		private void Update()
		{
			//Ensures that the players zed axis stays at -2
			if (playerBody.transform.position.z != playerZed)
			{
				playerBody.transform.position = new Vector3 (0f, 0f, playerZed);
			}
			//Revert change and direction
			change = Vector2.zero;
			direction = Vector3.zero;
			//Move player
			MovePlayer();
		}

		private void MovePlayer()
		{
			//Check if change is changed with input
			change = moveInput.ReadValue<Vector2>();
			direction = new Vector3(change.x, 0f, change.y);

			direction.Normalize();

			if (change != Vector2.zero)
			{
				//Find angles to rotate players
				float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
				float angle = Mathf.SmoothDampAngle(playerBody.transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
				//Rotate player in correct direction
				playerBody.transform.rotation = Quaternion.Euler(0f, angle, 0f);

				//Move player
				playerBody.transform.position = new Vector3(playerBody.transform.position.x + change.x * playerWalkSpeed * Time.deltaTime, playerBody.transform.position.y + change.y * playerWalkSpeed * Time.deltaTime, playerZed);
			}
		}

		private void OnEnable()
		{
			moveInput.Enable();
			runInput.Enable();
		}

		private void OnDisable()
		{
			moveInput.Disable();
			runInput.Disable();
		}

		#endregion
	}
}
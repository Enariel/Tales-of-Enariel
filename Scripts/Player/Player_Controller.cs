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
		[SerializeField] private Animator playerAnim;
		[SerializeField] private CharacterController playerCharacterController;
		//Variables
		private Vector2 change = new Vector2(0f, 0f);
		#endregion

		#region Unity Methods
		private void Awake()
		{
			//Get references
			playerCharacterController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
			playerAnim = playerCharacterController.gameObject.GetComponent<Animator>();

			//Generate player input
			if (inputActions == null)
			{
				inputActions = new Controls();
			}

			//Input actions
			moveInput = inputActions.Movement.Walk;
			runInput = inputActions.Movement.Run;
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

		//Getters
		public Controls InputActions { get => inputActions; }
		public InputAction MoveInput { get => moveInput; }
		public InputAction RunInput { get => runInput; }
		public Vector2 Change { get => change; set => change = value; }
		public CharacterController PlayerCharacterController { get => playerCharacterController; }
	}
}
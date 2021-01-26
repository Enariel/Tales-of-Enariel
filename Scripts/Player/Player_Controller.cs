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
		private InputAction useItem;
		private InputAction interactInput;
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
			useItem = inputActions.Movement.UseItem;
			interactInput = inputActions.Movement.Interact;
		}

		private void Update()
		{
			if (interactInput.ReadValue<float>() > .1f)
			{
				Collider[] objs = Physics.OverlapSphere(this.gameObject.transform.position, 5f);

				foreach (Collider obj in objs)
				{
					if (obj.gameObject.CompareTag("Item"))
					{
						var item = obj.GetComponent<Item_Object>();
						item.Interact();
					}
				}
			}
		}
		private void OnEnable()
		{
			moveInput.Enable();
			runInput.Enable();
			useItem.Enable();
			interactInput.Enable();
		}

		private void OnDisable()
		{
			moveInput.Disable();
			runInput.Disable();
			useItem.Disable();
			interactInput.Disable();
		}

		#endregion

		//Getters
		public Controls InputActions { get => inputActions; }
		public InputAction MoveInput { get => moveInput; }
		public InputAction RunInput { get => runInput; }
		public InputAction UseInput { get => useItem; }
		public Vector2 Change { get => change; set => change = value; }
		public CharacterController PlayerCharacterController { get => playerCharacterController; }
	}
}
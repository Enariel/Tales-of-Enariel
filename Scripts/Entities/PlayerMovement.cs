//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using Tales_Of_Enariel.StaffCasting;
using UnityEngine;
using UnityEngine.AI;

namespace Tales_Of_Enariel.Entities
{
	public class PlayerMovement : MonoBehaviour
    {
        #region Variables
        //References
        [SerializeField] private NavMeshAgent agent;
		[SerializeField] private Camera mainCam;
		[SerializeField] private Animator animator;
		//Variables

		//Properties
		#endregion

		#region Unity Methods

		private void Awake()
		{
			mainCam = Camera.main;
			agent = GetComponent<NavMeshAgent>();
			animator = GetComponentInChildren<Animator>();
		}

		private void Update()
		{
			SetDestination();

			animator.SetFloat("Speed", agent.velocity.magnitude);
		}

		private void OnEnable()
		{
			ComboManager.OnComboStart += HaltMovement;
		}

		private void OnDisable()
		{
			ComboManager.OnComboStart -= HaltMovement;
		}
		#endregion
		private void SetDestination()
		{
			if (Input.GetMouseButton(1))
			{
				Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;

				if (Physics.Raycast(ray, out hit))
				{
					agent.SetDestination(hit.point);
				}
			}
		}

		private void SetDirection()
		{

		}

		private void HaltMovement()
		{
			Debug.Log(transform.position);
			agent.SetDestination(transform.position);
		}

	}
}

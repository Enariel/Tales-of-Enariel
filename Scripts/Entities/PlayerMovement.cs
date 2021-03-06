//copyright(c) FuchsFarbe
//Author: Oliver

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

			if (agent.velocity != Vector3.zero)
			{
				//player is moving
			}
			else
			{
				//player is idle
			}
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
					Debug.Log(hit.point);
				}
			}
		}
	}
}

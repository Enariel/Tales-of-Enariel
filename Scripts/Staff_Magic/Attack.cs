//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	//TODO
	//Need to know what element is equipped
	//Need to pass element to the current relics
	//The relics have events executed here, passing in the element
	//The relic data comes from a list of active relics in an inventory

	//Need to implement combo system

    public class Attack : MonoBehaviour
    {
		#region Variables
		private Animator anim;
		private RelicManager rm;
		private ElementManager em;
		#endregion

		#region Unity Methods
		private void Awake()
		{
			anim = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
			rm = GetComponent<RelicManager>();
			em = GetComponent<ElementManager>();
		}

		private void Start()
		{
			
		}

		private void Update()
		{

		}
		#endregion
	}
}

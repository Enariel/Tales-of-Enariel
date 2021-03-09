//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	//Get input and load it into new spell data and fire events.
	public class Spellcaster : MonoBehaviour
	{
		public static Action OnComboStart;

		[SerializeField] private RelicManager rm;
		[SerializeField] private ElementManager em;
		[SerializeField] private Animator anim;
		[SerializeField] private GameObject caster;
		[SerializeField] private GameObject playerCaster;
		[SerializeField] private Camera mainCam;

		[SerializeField] private Spell currentSpell;

		public Spell CurrentSpell { get => currentSpell; set => currentSpell = value; }

		private void Awake()
		{
			rm = GetComponent<RelicManager>();
			em = GetComponent<ElementManager>();
			mainCam = Camera.main;
			playerCaster = GameObject.FindGameObjectWithTag("Player");
		}

		public void Update()
		{
			if (Input.GetMouseButtonUp(0))
			{
				OnComboStart?.Invoke();
			}
		}

		public void OnEnable()
		{
			OnComboStart += ExecutePlayerSpell;
		}

		public void OnDisable()
		{
			OnComboStart -= ExecutePlayerSpell;
		}

		private void ExecutePlayerSpell()
		{
			anim = playerCaster.GetComponentInChildren<Animator>();

			Vector3 target = new Vector3();

			Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				target = hit.point;
			}

			//Create new spell
			currentSpell = new Spell(em.CurrentElementData, rm.CurrentRelics, playerCaster, target);

			//Invoke the beginning of the spell.
			RelicManager.OnRelicStart.Invoke(currentSpell, playerCaster, target);
			anim.SetTrigger("Attack");
		}
	}
}

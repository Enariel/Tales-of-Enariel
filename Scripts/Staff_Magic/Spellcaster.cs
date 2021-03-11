//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	//Get input and load it into new spell data and fire events.
	public class Spellcaster : MonoBehaviour
	{
		public static Action OnPlayerCast;

		[SerializeField] private RelicManager rm;
		[SerializeField] private ElementManager em;
		[SerializeField] private ComboManager cm;
		[SerializeField] private Animator anim;
		[SerializeField] private GameObject caster;
		[SerializeField] private Camera mainCam;

		[SerializeField] private Spell currentSpell;

		public Spell CurrentSpell { get => currentSpell; set => currentSpell = value; }

		private void Awake()
		{
			rm = this.gameObject.GetComponent<RelicManager>();
			em = this.gameObject.GetComponent<ElementManager>();
			cm = this.gameObject.GetComponent<ComboManager>();
			mainCam = Camera.main;
			caster = this.gameObject;
		}

		public void OnEnable()
		{
			OnPlayerCast += PlayerCast;
		}

		public void OnDisable()
		{
			OnPlayerCast -= PlayerCast;
		}

		private void PlayerCast()
		{
			Vector3 direction = new Vector3();

			Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				direction = hit.point;
			}

			Debug.Log("Spell direction is: " + direction.normalized);

			RelicData rd = rm.RelicChainData[cm.ComboStage - 1];
			
			if (rd == null)
			{
				rd = rm.DefaultRelic;
			}

			currentSpell = new Spell(em.CurrentElementData, rd, caster, direction);

			StartCoroutine(currentSpell.StartSpell());
		}

		private string LogData(Spell spell)
		{
			string s = $"\n" +
				$"=========================================\n" +
				$"---------- Spell Information ------------" +
				$"Main Element: {spell.ElementData.Element.ToString()}\n" +
				$"Relic: {spell.CurrentRelicData.name}\n" +
				$"-----------------------------------------\n" +
				$"-------------- Update Datas -------------" +
				$"Caster:               {spell.Caster.name}\n" +
				$"State:                {spell.RelicState}";

			return s;
		}
	}
}

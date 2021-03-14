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
		public static Action SetSpell;

		[SerializeField] private RelicManager rm;
		[SerializeField] private ElementManager em;
		[SerializeField] private ComboManager cm;
		[SerializeField] private Animator anim;
		[SerializeField] private GameObject caster;
		[SerializeField] private Camera mainCam;

		[SerializeField] private Spell currentSpell;
		[SerializeField] private Vector3 targetOrDirection;

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
			ComboManager.OnComboStart += SetTargetDirection;
		}

		public void OnDisable()
		{
			OnPlayerCast -= PlayerCast;
			ComboManager.OnComboStart += SetTargetDirection;
		}

		private void PlayerCast()
		{
			RelicData relicData = rm?.RelicChainData[cm.ComboStage - 1];

			if (relicData == null)
			{
				relicData = rm.DefaultRelic;
			}

			//Create new 'Spell' with the current offhand element, the relic[comboStage], passing in the caster obj and direction.
			currentSpell = new Spell(em.CurrentElementData, relicData, caster, targetOrDirection);
			StartCoroutine(currentSpell.Cast());
		}

		private void SetTargetDirection()
		{
			targetOrDirection = new Vector3();
			Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				targetOrDirection = hit.point;
			}
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

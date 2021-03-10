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
		[SerializeField] private Animator anim;
		[SerializeField] private GameObject caster;
		[SerializeField] private GameObject playerCaster;
		[SerializeField] private Camera mainCam;

		[SerializeField] private TextAsset log;

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
				OnPlayerCast?.Invoke();
			}
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
			StreamWriter s = new StreamWriter(log.name, true);
			ComboManager cm = playerCaster.GetComponent<ComboManager>();

			Vector3 target = new Vector3();

			Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				target = hit.point;
			}

			//Create new spell
			currentSpell = new Spell(em.CurrentElementData, rm.RelicChainData[cm.ComboStage], playerCaster, target);
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

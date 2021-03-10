//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	public class ComboManager : MonoBehaviour
	{
		//Combo needs the offhand element, current stage of the combo, and the relic at the corresponding stage;
		//A new spell is defined by the element as well as the stage the combo is at with the corresponding relic.
		//Each relic takes in an element to define what it does in the SO.
		//Combo stage

		[SerializeField] [Range(0, 3)] private int comboStage;
		[Tooltip("Time between clicking the player can increment the combo.")] 
		[SerializeField] private float maxTime;
		[SerializeField] private float curTime;

		//Properties
		public int ComboStage { get => comboStage; }

		private void Update()
		{
			if (curTime > 0)
			{
				curTime -= Time.deltaTime;
			}
		}

		private void OnEnable()
		{
			Spellcaster.OnPlayerCast += DoCombo;
		}

		private void OnDisable()
		{
			Spellcaster.OnPlayerCast -= DoCombo;
		}

		private void DoCombo()
		{
			curTime = maxTime;
			comboStage++;
		}

		private void TryIncrementCombo()
		{

		}
	}
}

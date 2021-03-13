//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Tales_Of_Enariel.StaffCasting
{
	//This class manages the combo steps and stages

	public class ComboManager : MonoBehaviour
	{
		//Events
		public static Action OnComboStart;
		public static Action OnCombatEnd;
		public static Action<int> OnCombatStage;
		//Input
		private Controls c;
		private InputAction attackAction;
		//Combo
		[SerializeField] private bool comboPossible;
		[SerializeField] private int stage;
		[SerializeField] private int maxCombo;

		public int ComboStage { get => stage; }

		private void Awake()
		{
			//Set up inputs
			c = new Controls();
			attackAction = c.Combat.Attack;

			//Input events
			attackAction.performed += ctx => Attack();
		}
		private void Update()
		{
			SetComboAnimParams();
		}

		private void OnEnable()
		{
			attackAction.Enable();
		}

		private void OnDisable()
		{
			attackAction.Disable();
		}

		public void Attack()
		{
			if (stage > maxCombo)
			{
				stage = 0;
			}
			if (stage == 0)
			{
				stage += 1;
			}
			if (stage != 0)
			{
				if (comboPossible)
				{
					comboPossible = false;
					stage += 1;
				}
			}

			OnComboStart?.Invoke();
		}

		public void ComboPossible()
		{
			comboPossible = true;
		}

		public void SetComboAnimParams()
		{
			OnCombatStage?.Invoke(stage);
		}

		public void ComboReset()
		{
			comboPossible = false;
			stage = 0;
		}
	}
}

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
		//Input
		private Controls c;
		private InputAction attackAction;
		//Animator
		[SerializeField] private Animator anim;
		[SerializeField] private string comboAnimParam;
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

			//Animator
			anim = this.gameObject.GetComponent<Animator>();

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
				Spellcaster.OnPlayerCast.Invoke();
			}
			if (stage != 0)
			{
				if (comboPossible)
				{
					comboPossible = false;
					stage += 1;
					Spellcaster.OnPlayerCast.Invoke();
				}
			}
		}

		public void ComboPossible()
		{
			comboPossible = true;
		}

		public void SetComboAnimParams()
		{
			anim.SetInteger(comboAnimParam, stage);
		}

		public void ComboReset()
		{
			comboPossible = false;
			stage = 0;
		}
	}
}

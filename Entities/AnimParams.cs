using System;
using System.Collections;
using System.Collections.Generic;
using Tales_Of_Enariel.StaffCasting;
using UnityEngine;


namespace Tales_Of_Enariel.Entities
{
	public class AnimParams : MonoBehaviour
	{
		private Animator animator;
		[Header("Bools")]
		[SerializeField] private string combatMode;
		[SerializeField] private string hasMana;
		[SerializeField] private string hasHealth;
		[Header("Floats")]
		[SerializeField] private string speed;
		[SerializeField] private string animSpeedMod;
		[Header("Integers")]
		[SerializeField] private string offHandElement;
		[SerializeField] private string combatStage;
		[Header("Triggers")]
		private string die;

		[Header("Animator variables")]
		private Dictionary<string, int> elementDict = new Dictionary<string, int>();

		private void Awake()
		{
			animator = this.GetComponent<Animator>();
			SetElementDictionary();
		}

		private void SetElementDictionary()
		{
			int i = 0;
			foreach (Element e in Enum.GetValues(typeof(Element)))
			{
				elementDict.Add(e.ToString(), i);
				i++;
			}
		}

		private void OnEnable()
		{
			ComboManager.OnComboStart += SetCombatMode;
			ComboManager.OnCombatStage += SetCombatStage;
			ElementManager.OnElementChange += SetElement;
		}

		private void OnDisable()
		{
			ComboManager.OnComboStart -= SetCombatMode;
			ComboManager.OnCombatStage -= SetCombatStage;
			ElementManager.OnElementChange += SetElement;
		}

		private void SetCombatMode()
		{
			StopCoroutine(CombatTimer());
			animator.SetBool(combatMode, true);
			StartCoroutine(CombatTimer());
		}

		private void SetCombatStage(int stage)
		{
			animator.SetInteger(combatStage, stage);
		}

		private IEnumerator CombatTimer(float timeInSeconds = 10f)
		{
			yield return new WaitForSeconds(timeInSeconds);
			animator.SetBool(combatMode, false);
		}

		private void SetElement(Element el)
		{
			animator.SetInteger(offHandElement, elementDict[el.ToString()]);
		}

	}
}

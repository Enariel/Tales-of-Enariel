using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.Inventory
{
	public class EEquipment : MonoBehaviour
	{
		[SerializeField] protected EquipmentData[] curEquips = new EquipmentData[8];
		[SerializeField] protected List<float> hpBonuses, phyrBonuses, stamBonuses, dexBonuses, strBonuses, intBonuses, defBonuses, moveBonuses, jumpBonuses;
		[SerializeField] private float HPBonus, PhyrBonus, StamBonus, DexBonus, StrBonus, IntBonus, DefBonus, MoveBonus, JumpBonus;

		int CountTotals(List<float> statBonusList)
		{
			float statTotal = 0f;

			foreach (float i in statBonusList)
			{
				statTotal += i;
			}

			return (int)statTotal;
		}

		public void Tally()
		{
			//Clear lists of floats and current bonuses.
			hpBonuses.Clear();
			phyrBonuses.Clear();
			stamBonuses.Clear();
			dexBonuses.Clear();
			strBonuses.Clear();
			intBonuses.Clear();
			defBonuses.Clear();
			moveBonuses.Clear();
			jumpBonuses.Clear();

			HPBonus = 0f;
			PhyrBonus = 0f;
			StamBonus = 0f;
			DexBonus = 0f;
			StrBonus = 0f;
			IntBonus = 0f;
			DefBonus = 0f;
			MoveBonus = 0f;
			JumpBonus = 0f;

			//Tally up each stat that the equipment modified
			foreach (EquipmentData eq in curEquips)
			{
				if (eq != null)
				{
					hpBonuses.Add(eq.HpMod);
					phyrBonuses.Add(eq.PhyrMod);
					stamBonuses.Add(eq.StamMod);
					dexBonuses.Add(eq.DexMod);
					strBonuses.Add(eq.StrMod);
					intBonuses.Add(eq.IntMod);
					defBonuses.Add(eq.DefMod);
					moveBonuses.Add(eq.MoveMod);
					jumpBonuses.Add(eq.JumpMod);
				}
			}

			//Summation of each list is the total equipment bonus per stat.
			HPBonus = CountTotals(hpBonuses);
			PhyrBonus = CountTotals(phyrBonuses);
			StamBonus = CountTotals(stamBonuses);
			DexBonus = CountTotals(dexBonuses);
			StrBonus = CountTotals(strBonuses);
			IntBonus = CountTotals(intBonuses);
			DefBonus = CountTotals(defBonuses);
			MoveBonus = CountTotals(moveBonuses);
			JumpBonus = CountTotals(jumpBonuses);
		}
	}
}

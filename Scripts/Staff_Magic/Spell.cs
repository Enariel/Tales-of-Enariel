//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	/**
	 * A spell is the finalization of data at a particular combo stage.
	 * It takes the relic data from an array. The relic array corresponds to combo stage.
	 * The element will be the current offhand element.
	 * A spell takes the current offhand plus the relic data at the corresponding stage and
	 * creates a new spell data class with it.
	 */
	[System.Serializable]
	public class Spell
	{
		//The active spell is made of the current element and the forms currently selected.
		//A new active spell is created each time a spell is cast by the player. 

		#region Variables
		//References
		[SerializeField] private RelicData curRelicData;
		[SerializeField] private ElementData elementData;
		[SerializeField] private GameObject caster;
		[SerializeField] private Vector3 target = new Vector3();
		
		//Variables
		[SerializeField] private GameObject spellPrefab = new GameObject();
		[SerializeField] private Collider col = new Collider();
		[SerializeField] private AoEData aoe = new AoEData();
		private string state;

		//Properties
		public ElementData ElementData { get => elementData; set => elementData = value; }
		public RelicData CurrentRelicData { get => curRelicData; set => curRelicData = value; }
		public GameObject Caster { get => caster; set => caster = value; }
		public GameObject SpellPrefab { get => spellPrefab; set => spellPrefab = value; }
		public Vector3 TargetDirection { get => target; set => target = value; } 
		public string RelicState { get => state; }
		#endregion

		public Spell(ElementData _elementData, RelicData _relicData, GameObject _casterObj, Vector3 _target)
		{
			this.elementData = _elementData;
			this.curRelicData = _relicData;
			this.caster = _casterObj;
			this.target = _target;
			this.spellPrefab = _elementData.MainPrefab;
			this.aoe = _elementData.AoEData;
		}

		public IEnumerator StartSpell()
		{
			state = "";
			//Invoke the beginning of the spell.
			state = "Start";
			yield return curRelicData.StartRelicAction(this, target);
			yield return UpdateSpell();
		}

		public IEnumerator UpdateSpell()
		{
			//Update the spell over frames depending on the current relic.
			int i = 0;
			while (i < 100)
			{
				yield return curRelicData.UpdateRelicAction(this, target);
				Debug.Log("Updating" + curRelicData.RelicName);
				i++;
			}
		}

		public IEnumerator EndSpell()
		{
			state = "End";
			yield return curRelicData.EndRelicAction(this, target);
			state = "";
		}
	}
}

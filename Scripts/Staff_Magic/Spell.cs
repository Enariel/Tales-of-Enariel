//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{

	[System.Serializable]
	public class Spell
	{
		//The active spell is made of the current element and the forms currently selected.
		//A new active spell is created each time a spell is cast by the player. 
		private List<RelicData> relicDatas = new List<RelicData>();
		private ElementData elementData = new ElementData();
		private GameObject spellPrefab = new GameObject();
		private GameObject caster = new GameObject();
		private Vector3 target = new Vector3(); //The direction to cast the spell in
		private Collider col = new Collider();
		private AoEData aoe = new AoEData();

		public Spell(ElementData _elementData, List<RelicData> _relicDatas, GameObject _casterObj, Vector3 _target)
		{
			this.elementData = _elementData;
			this.relicDatas = _relicDatas;
			this.caster = _casterObj;
			this.target = _target;
			this.spellPrefab = _elementData.MainPrefab;
			this.aoe = _elementData.AoEData;
		}

		public ElementData ElementData { get => elementData; set => elementData = value; }
		public List<RelicData> RelicDatas { get => relicDatas; set => relicDatas = value; }
		public GameObject Caster { get => caster; set => caster = value; }
		public GameObject SpellPrefab { get => spellPrefab; set => spellPrefab = value; }
		public Vector3 TargetDirection { get => target; set => target = value; }
	}
}

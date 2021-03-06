//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
    public class RelicData : ScriptableObject
    {
        #region Variables
        [SerializeField] private string relicName;
        [SerializeField] private string relicDesc;
        [SerializeField] private string relicID;
		#endregion

		#region Unity Methods
		private void OnEnable()
		{
			
		}

		private void OnDisable()
		{
			
		}
		#endregion
	}

	[System.Serializable]
	public class ActiveSpell
	{
		//The active spell is made of the current element and the forms currently selected.
		//A new active spell is created each time a spell is cast by the player. 
		private ElementData elementData;
		private List<RelicData> relicDatas = new List<RelicData>();
		private GameObject caster;
		private Vector3 targetDirection; //The direction to cast the spell in

		public ActiveSpell(ElementData elementData, List<RelicData> relicDatas, GameObject caster, Vector3 targetDirection)
		{
			this.elementData = elementData;
			this.relicDatas = relicDatas;
			this.caster = caster;
			this.targetDirection = targetDirection;
		}
	}
}

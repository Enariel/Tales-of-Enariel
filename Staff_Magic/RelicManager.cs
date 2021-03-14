//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	public class RelicManager : MonoBehaviour
    {
		//Events
		public static Action<Spell, GameObject, Vector3> OnRelicStart;
		public static Action<Spell, GameObject, Vector3> OnRelicUpdate;
		public static Action<Spell, GameObject, Vector3> OnRelicEnd;

		#region Variables
		[SerializeField] private RelicData[] relicChain = new RelicData[4];
		[SerializeField] private List<RelicData> relicInventory;
		[SerializeField] private RelicData defaultRelic;

		//Properties
		public List<RelicData> RelicInventory { get => relicInventory; set => relicInventory = value; }
		public RelicData[] RelicChainData { get => relicChain; }
		public RelicData DefaultRelic { get => defaultRelic; }
		#endregion
	}
}

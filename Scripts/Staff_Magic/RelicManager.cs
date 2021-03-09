//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
    public class RelicManager : MonoBehaviour
    {
		public static Action<Spell, GameObject, Vector3> OnRelicStart;
		public static Action<Spell, GameObject, Vector3> OnRelicUpdate;
		public static Action<Spell, GameObject, Vector3> OnRelicEnd;

		#region Variables
		[SerializeField] private List<RelicData> currentRelics;
		[SerializeField] private List<RelicData> relicInventory;

		public List<RelicData> CurrentRelics { get => currentRelics; set => currentRelics = value; }
		public List<RelicData> RelicInventory { get => relicInventory; set => relicInventory = value; }
		#endregion
	}
}

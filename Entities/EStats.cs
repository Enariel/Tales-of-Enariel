//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using Tales_Of_Enariel.Inventory;
using UnityEngine;

namespace Tales_Of_Enariel.Entities
{
    public class EStats : MonoBehaviour
    {
		public Action OnStatRefresh;
        #region Variables
        //References
        [SerializeField] protected EntityData eData;
		[SerializeField] protected EEquipment entityEquipment;
		//Variables
		[SerializeField] private float curHp, curPhyr, curStam, curInt, curStr, curDex, curDef;
        [SerializeField] private float maxHp, maxPhyr, maxStam, maxInt, maxStr, maxDex, maxDef;
		//Properties
		#endregion

		#region Unity Methods

		private void Awake()
		{
			entityEquipment = GetComponent<EEquipment>();
		}

		private void OnEnable()
		{
			OnStatRefresh += RecalculateMaxStats;
		}

		private void OnDisable()
		{
			OnStatRefresh -= RecalculateMaxStats;
		}
		#endregion

		private void RecalculateMaxStats()
		{

		}
	}
}

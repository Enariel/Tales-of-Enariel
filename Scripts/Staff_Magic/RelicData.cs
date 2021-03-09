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
        [SerializeField] protected string relicName;
        [SerializeField] protected string relicDesc;
        [SerializeField] protected string relicID;
		[SerializeField] protected int relicTier;
		#endregion

		#region Unity Methods
		public virtual void OnEnable()
		{
			RelicManager.OnRelicStart += RelicStart;
			RelicManager.OnRelicUpdate += RelicUpdate;
			RelicManager.OnRelicEnd += RelicEnd;

			relicID = $"{relicName}_{relicTier}";
		}

		public virtual void OnDisable()
		{
			RelicManager.OnRelicStart -= RelicStart;
			RelicManager.OnRelicUpdate -= RelicUpdate;
			RelicManager.OnRelicEnd -= RelicEnd;
		}

		public virtual void RelicStart(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log(relicName + "On Start");
		}
		public virtual void RelicUpdate(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log(relicName + "On Update");
		}
		public virtual void RelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log(relicName + "On End");
		}
		#endregion
	}
}

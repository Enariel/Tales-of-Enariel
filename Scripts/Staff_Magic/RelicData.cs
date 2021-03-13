//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections;
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

		//Properties
		public string RelicName { get => relicName; }
		public string RelicDesc { get => relicDesc; }
		public string RelicID { get => relicID; }
		public int RelicTier { get => relicTier; }
		#endregion

		#region Unity Methods
		public virtual void OnEnable()
		{

			relicID = $"{relicName}_{relicTier}";
		}

		public virtual void OnDisable()
		{

		}
		#endregion

		#region RelicStates
		//Initialize
		//The spell starts to be cast
		//Create prefabs here, add behaviours elsewhere.
		public virtual IEnumerator InitializeRelic(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log("Started relic action");
			yield return null;
		}

		//Add behaviours to created prefabs
		public virtual IEnumerator OnRelicSuccess(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log("Updating relic action");
			yield return null;
		}

		public virtual IEnumerator OnRelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			Debug.Log("Ending relic action");
			yield return null;
		} 

		public virtual IEnumerator OnRelicHit(Spell spell, GameObject hit)
		{
			yield return null;
		}

		#endregion

		protected GameObject InitializeSpellPrefab(GameObject prefab, Transform spawnTransform, Vector3 targetPos = new Vector3(), float offset = 1.5f)
		{
			Vector3 dir = spawnTransform.position - targetPos;
			dir.Normalize();
			Vector3 spawnPoint = new Vector3 (dir.x * offset, spawnTransform.position.y + 1, dir.z * offset);
			
			GameObject spellPreFab = Instantiate(prefab, spawnTransform.position + spawnPoint, spawnTransform.rotation);

			return spellPreFab;
		}
	}


}

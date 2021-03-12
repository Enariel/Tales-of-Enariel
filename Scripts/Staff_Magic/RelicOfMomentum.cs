//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Momentum", menuName = "Staff-Casting/Relics/Relic of Momentum")]
	public class RelicOfMomentum : RelicData
	{
		[SerializeField] private float speed;
		[SerializeField] private float maxD;

		#region Unity Methods
		public override void OnEnable()
		{
			base.OnEnable();
		}

		public override void OnDisable()
		{
			base.OnDisable();
		}

		#endregion

		#region Relic Override States
		public override IEnumerator InitializeRelic(Spell spell, GameObject caster, Vector3 target)
		{
			base.InitializeRelic(spell, caster, target);

			GameObject spellPrefab = InitializeSpellPrefab(spell.SpellPrefab, caster.transform);
			var projInst = spellPrefab.AddComponent<Projectile>();
			yield return projInst.FireProjectile(target);
		}

		public override IEnumerator OnRelicSuccess(Spell spell, GameObject caster, Vector3 target)
		{
			return base.OnRelicSuccess(spell, caster, target);
		}

		public override IEnumerator OnRelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			return base.OnRelicEnd(spell, caster, target);
		}

		public override IEnumerator OnRelicHit(Spell spell, GameObject hit)
		{
			return base.OnRelicHit(spell, hit);
		}
		#endregion
	}

	public class Projectile : MonoBehaviour
	{
		//Instance references
		Spell spellInst;

		Vector3 spawnPos;
		Vector3 spawnDir;
		Vector3 targetPos;
		float speed = 10;

		public IEnumerator FireProjectile(Vector3 targetPos)
		{
			var d = Vector3.Distance(this.gameObject.transform.position, targetPos);

			while (d > .1f)
			{
				this.gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

				yield return new WaitForEndOfFrame();
			}

			yield break;
		}
	}
}

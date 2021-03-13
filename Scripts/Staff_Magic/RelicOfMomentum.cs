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

			GameObject spellPrefab = InitializeSpellPrefab(spell.SpellPrefab, caster.transform, target, -1.25f);

			var projInst = CreateProjectileInst(spellPrefab, spell, spell.ElementData.ElementProjectileSpeed);

			projInst.SpellInst = spell;

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

		protected Projectile CreateProjectileInst(GameObject projectile, Spell s, float speed)
		{
			Projectile p = projectile.AddComponent<Projectile>();
			p.SpellInst = s;
			p.Speed = speed;

			return p;
		}
	}

	[RequireComponent(typeof(Rigidbody), typeof(Collider))]
	public class Projectile : MonoBehaviour
	{
		//Instance references
		Spell spellInst;
		float speed;
		//Prefab refs
		private Rigidbody rb;
		private Collider col;

		private void Start()
		{
			rb = this.gameObject.GetComponent<Rigidbody>();
			col = this.gameObject.GetComponent<Collider>();
		}

		public Spell SpellInst { get => spellInst; set => spellInst = value; }
		public float Speed { get => speed; set => speed = value; }

		public IEnumerator FireProjectile(Vector3 targetPos)
		{
			var d = Vector3.Distance(this.gameObject.transform.position, targetPos);
			targetPos = new Vector3(targetPos.x, targetPos.y + 1, targetPos.z);

			while (d > .25f)
			{
				this.gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

				yield return new WaitForEndOfFrame();
			}

			yield break;
		}

		public void OnCollisionEnter(Collision collision)
		{

		}
	}
}

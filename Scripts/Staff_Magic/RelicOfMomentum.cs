//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Momentum", menuName = "Staff-Casting/Relics/Relic of Momentum")]
	public class RelicOfMomentum : RelicData
	{
		[SerializeField] private float speed;

		public override void OnEnable()
		{
			base.OnEnable();
		}

		public override void OnDisable()
		{
			base.OnDisable();
		}

		public override void RelicStart(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicStart(spell, caster, target);

			spell.SpellPrefab = Instantiate(spell.SpellPrefab, caster.transform.position + new Vector3(0, 1, 1), Quaternion.identity);
		}

		public override void RelicUpdate(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicUpdate(spell, caster, target);

			GameObject spfb = spell.ElementData.MainPrefab;

			if (Vector3.Distance(spfb.transform.position, target) > .5f)
			{
				spfb.transform.position += new Vector3(target.x * speed * Time.deltaTime, 0,target.z * speed * Time.deltaTime);
			}
		}

		public override void RelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicEnd(spell, caster, target);

			spell.ElementData.MainParticleEffect.Stop();
		}
	}
}

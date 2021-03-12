//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Control", menuName = "Staff-Casting/Relics/Relic of Control")]
	public class RelicOfControl : RelicData
	{
		#region Relic Override States

		#endregion
		public override IEnumerator InitializeRelic(Spell spell, GameObject caster, Vector3 target)
		{
			return base.InitializeRelic(spell, caster, target);
		}

		public override void OnEnable()
		{
			base.OnEnable();
		}

		public override IEnumerator OnRelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			return base.OnRelicEnd(spell, caster, target);
		}

		public override IEnumerator OnRelicHit(Spell spell, GameObject hit)
		{
			return base.OnRelicHit(spell, hit);
		}

		public override IEnumerator OnRelicSuccess(Spell spell, GameObject caster, Vector3 target)
		{
			return base.OnRelicSuccess(spell, caster, target);
		}
	}
}
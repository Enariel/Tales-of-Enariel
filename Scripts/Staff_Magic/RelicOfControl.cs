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
		public override IEnumerator StartRelicAction(Spell spell, Vector3 target)
		{
			return base.StartRelicAction(spell, target);
		}

		public override IEnumerator UpdateRelicAction(Spell spell, Vector3 target)
		{
			return base.UpdateRelicAction(spell, target);
		}

		public override IEnumerator EndRelicAction(Spell spell, Vector3 target)
		{
			return base.EndRelicAction(spell, target);
		}
		#endregion
	}
}
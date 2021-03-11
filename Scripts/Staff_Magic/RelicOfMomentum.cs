﻿//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Momentum", menuName = "Staff-Casting/Relics/Relic of Momentum")]
	public class RelicOfMomentum : RelicData
	{
		[SerializeField] private float speed;

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

//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Song", menuName = "Staff-Casting/Relics/Relic of Song")]
	public class RelicOfSong : RelicData
	{
		#region Overrides
		public override void OnDisable()
		{
			base.OnDisable();
		}

		public override void OnEnable()
		{
			base.OnEnable();
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
		private Collider SetCollider(AoEData data)
		{
			switch (data.AoEType)
			{
				case AoEType.Rectangle:
					return SetRectCollider(data.Size);
				case AoEType.Sphere:
					return SetSphereCollider(data.Radius);
			}
			return null;
		}

		private SphereCollider SetSphereCollider(float radius)
		{
			SphereCollider s = new SphereCollider();
			s.radius = radius;
			return s;
		}
		private BoxCollider SetRectCollider(Vector3 size)
		{
			BoxCollider b = new BoxCollider();
			b.size = size;
			return b;
		}
	}
}

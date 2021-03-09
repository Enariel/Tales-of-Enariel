//copyright(c) FuchsFarbe
//Author: Oliver

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

		public override void RelicStart(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicStart(spell, caster, target);


		}

		public override void RelicUpdate(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicUpdate(spell, caster, target);

			Debug.Log(spell.ElementData.AoEData);
		}

		public override void RelicEnd(Spell spell, GameObject caster, Vector3 target)
		{
			base.RelicEnd(spell, caster, target);
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

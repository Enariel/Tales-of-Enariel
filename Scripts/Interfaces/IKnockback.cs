using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel
{
	public interface IKnockback
	{
		public void Knockback(float force, List<GameObject> victims);
		public void Knockback(float force, GameObject victim);
	}
}

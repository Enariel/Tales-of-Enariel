using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel
{
	public interface IRotate
	{
		public void RotateAround(GameObject body, GameObject satellite);
		public void RotateAround(GameObject body, List<GameObject> satellites);
	}
}

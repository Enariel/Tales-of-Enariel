//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[System.Serializable]
	public class AoEData
	{
		[SerializeField] private AoEType aoeType;
		[SerializeField] private float radius;
		[SerializeField] private Vector3 size;

		public AoEData(AoEType _AoEType = AoEType.Sphere, float _radius = 1, float l = 1, float w = 1, float h = 1)
		{
			this.aoeType = _AoEType;
			this.radius = _radius;
			this.size = new Vector3(l, w, h);
		}

		public AoEType AoEType { get => aoeType; }
		public float Radius { get => radius; }
		public Vector3 Size { get => size; }
	}
}

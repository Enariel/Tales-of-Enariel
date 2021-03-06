//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Element", menuName = "Staff-Casting/Element")]
    public class ElementData : ScriptableObject
    {
        #region Variables
        [SerializeField] private Element element;
        [SerializeField] private GameObject mainPrefab;
        [SerializeField] private GameObject AoEPrefab;
        [SerializeField] private GameObject DoTPrefab;
        [SerializeField] private GameObject miscEffect;
        [SerializeField] private ParticleSystem mainParticleEffect;
        [SerializeField] private Sprite elementIcon;

		public Element Element { get => element; }
		public GameObject MainPrefab { get => mainPrefab; }
		public GameObject AoE_Prefab { get => AoEPrefab; }
		public GameObject DoT_Prefab { get => DoTPrefab; }
		public GameObject MiscEffect { get => miscEffect; }
		public ParticleSystem MainParticleEffect { get => mainParticleEffect; }
		public Sprite ElementIcon { get => elementIcon; }
		#endregion
	}
}

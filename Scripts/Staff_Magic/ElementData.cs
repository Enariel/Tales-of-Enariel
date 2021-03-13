//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
	[CreateAssetMenu(fileName = "Element", menuName = "Staff-Casting/Element")]
    public class ElementData : ScriptableObject
    {
		#region Variables
		[Header("Cosmetic Data")]
		[SerializeField] private Element element;
		[SerializeField] private string elementName;
		[SerializeField] private string elementDesc;
		[SerializeField] private Sprite elementIcon;
		[Header("Game Data")]
		[SerializeField] private float projectileSpeed;
		[SerializeField] private AoEData aoeData = new AoEData();
		[SerializeField] private ParticleSystem mainParticleEffect;
		//TODO create an array to vary the spell prefabs.
		[SerializeField] private GameObject mainSpellPrefab;
		[SerializeField] private GameObject AoESpellPrefab;
        [SerializeField] private GameObject groundEffect;
        [SerializeField] private GameObject damageOverTimeEffect;

		public float ElementProjectileSpeed { get => projectileSpeed; }
		public Element Element { get => element; }
		public AoEData AoEData { get => aoeData; }
		public GameObject MainPrefab { get => mainSpellPrefab; }
		public GameObject AoE_Prefab { get => groundEffect; }
		public GameObject DoT_Prefab { get => damageOverTimeEffect; }
		public ParticleSystem MainParticleEffect { get => mainParticleEffect; }
		public Sprite ElementIcon { get => elementIcon; }
		#endregion
	}
}

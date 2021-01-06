//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.NPCs
{
    [CreateAssetMenu(fileName = "Nameless", menuName = "Scriptable Objects/New NPC")]
    public class NPC_Data : ScriptableObject
    {
        #region Variables
        //Variables
        [SerializeField] private GameObject npcPreFab;
        [SerializeField] private Sprite npcPortrait;
        [SerializeField] private string npcName;
        [SerializeField] private Race npcRace;

		public GameObject NpcPreFab { get => npcPreFab; private set => npcPreFab = value; }
		public Sprite NpcPortrait { get => npcPortrait; private set => npcPortrait = value; }
		public string NpcName { get => npcName; private set => npcName = value; }
		public Race NpcRace { get => npcRace; private set => npcRace = value; }
		//Properties

		#endregion
	}
}

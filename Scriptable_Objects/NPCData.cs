//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

/* ============================================
*               Entity Data
* --------------------------------------------
*       Entity Datas are scriptable object
*   assets that store information about a
*   specific entity. This would be things like 
*   base health and mana.
*  ===========================================
*/

namespace Tales_Of_Enariel.Entities
{
	[CreateAssetMenu(fileName = "NPC Data", menuName = "Entities/NPC")]
	public class NPCData : EntityData
	{
        #region Variables
        //Variables
        [SerializeField] private GameObject npcPreFab;
        [SerializeField] private Sprite npcPortrait;
        [SerializeField] private string npcName;
        [SerializeField] private Race npcRace;
        //Properties
        public GameObject NpcPreFab { get => npcPreFab; }
        public Sprite NpcPortrait { get => npcPortrait; }
        public string NpcName { get => npcName; }
        public Race NpcRace { get => npcRace; }
        #endregion

        public override void Interact()
		{
            Debug.Log("Interacting with NPC: " + NpcName);
		}
	}
}

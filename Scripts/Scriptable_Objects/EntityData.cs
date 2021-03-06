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
	public class EntityData : ScriptableObject, IInteractable
    {
    	#region Variables
        [Header("Transaction Stats")]
        [SerializeField] private float baseHealth; 
        [SerializeField] private float basePhyr;
        [SerializeField] private float baseStamina;
		//To keep things simple, we will only use a magic and physical based stat.
		[Header("Combat Stats")]
		[SerializeField] private int baseIntelligence;
		[SerializeField] private int baseStrength;
		[SerializeField] private int baseDexterity;
		[SerializeField] private int basePhysicalDefense;

		[Header("Locomotion Stats")]
		[SerializeField] private float baseMoveSpeed;
		[SerializeField] private float baseJumpHeight;

		[Header("Static Information")]
        //Static information about the entities
        [SerializeField] private string entityName;
        [SerializeField] private string entityDesc;

		public float BaseHealth { get => baseHealth; set => baseHealth = value; }
		public float BasePhyr { get => basePhyr; set => basePhyr = value; }
		public float BaseStamina { get => baseStamina; set => baseStamina = value; }
		public int BaseIntelligence { get => baseIntelligence; set => baseIntelligence = value; }
		public int BaseStrength { get => baseStrength; set => baseStrength = value; }
		public int BaseDexterity { get => baseDexterity; set => baseDexterity = value; }
		public int BasePhysicalDefense { get => basePhysicalDefense; set => basePhysicalDefense = value; }
		public float BaseMoveSpeed { get => baseMoveSpeed; set => baseMoveSpeed = value; }
		public float BaseJumpHeight { get => baseJumpHeight; set => baseJumpHeight = value; }
		public string EntityName { get => entityName; set => entityName = value; }
		public string EntityDesc { get => entityDesc; set => entityDesc = value; }
		#endregion

		//What happens when a player interacts with this entity
		public virtual void Interact()
		{
			Debug.Log($"Interacting with {entityName}");
		}
	}
}

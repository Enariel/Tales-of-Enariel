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
	[CreateAssetMenu(fileName = "New Player Data", menuName = "Scriptable Objects/Entities/Player")]
	public class Player_Data : Entity_Data
	{
		#region Player Variables
		#endregion

		//This should mostly do nothing, as the player shouldn't be able to iteract with themselves.
		public override void Interact()
		{
			base.Interact();
		}
	}
	public class Entity_Data : ScriptableObject, IInteractable
    {
    	#region Variables
    	//References

    	//Variables
        [Header("Transaction Stats")]
        [SerializeField] protected float baseHealth; 
        [SerializeField] protected float basePhyr;
        [SerializeField] protected float baseStamina;
		//To keep things simple, we will only use a magic and physical based stat.
		[Header("Attack Stats")]
		[SerializeField] protected int baseMagic;
		[SerializeField] protected int baseStrength;
		
		[Header("Defense Stats")]
		[SerializeField] protected int baseMagicDefense;
		[SerializeField] protected int basePhysicalDefense;

		[Header("Static Information")]
        //Static information about the entities
        [SerializeField] protected string entityName;
        [SerializeField] protected string entityDesc;
		#endregion

		//What happens when a player interacts with this entity
		public virtual void Interact()
		{
			Debug.Log($"Interacting with {entityName}");
		}
	}
}

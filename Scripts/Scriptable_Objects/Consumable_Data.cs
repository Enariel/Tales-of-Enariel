//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel
{
	[CreateAssetMenu(fileName = "New Consumable", menuName = "Scriptable Objects/Item/Consumable")]
	public class Consumable_Data : Item_Data
	{
		#region Variables
		[SerializeField] private int potionAmt; //Points to modify a stat of a player
		#endregion
		public override void UseItem()
		{
			Debug.Log($"This is a {itemName}, and this will effect a stat by {potionAmt}. Here is the {itemDesc}.");
		}
	}
}

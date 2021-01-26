//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel
{
    
    public abstract class Item_Data : ScriptableObject
    {
		#region Variables
		//Variables
		[SerializeField] protected string itemName;
		[SerializeField] protected string itemDesc;
		[SerializeField] protected string itemId;
		[SerializeField] protected Sprite itemIcon;
		[SerializeField] protected GameObject itemPrefab;

		public string ItemName { get => itemName; }
		public string ItemDesc { get => itemDesc; }
		public string ItemId { get => itemId; }
		public Sprite ItemIcon { get => itemIcon; }
		public GameObject ItemPrefab { get => itemPrefab; }
		#endregion

		public abstract void UseItem();
    }
}
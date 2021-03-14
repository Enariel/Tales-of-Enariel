//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.Inventory
{

	public abstract class ItemData : ScriptableObject
    {
		#region Variables
		//Variables
		[SerializeField] protected string itemId;
		[SerializeField] protected string itemName;
		[SerializeField] protected string generatedItemDesc;
		[SerializeField] protected string itemDescription;
		[SerializeField] protected Sprite itemIcon;
		[SerializeField] protected GameObject itemPrefab;

		public string ItemId { get => itemId; }
		public string ItemName { get => itemName; }
		public string GeneratedDescription { get => generatedItemDesc; }
		public string ItemDescription { get => itemDescription; }
		public Sprite ItemIcon { get => itemIcon; }
		public GameObject ItemPrefab { get => itemPrefab; }
		#endregion

		public void OnEnable()
		{
			SetInformation();
		}
		public virtual void SetInformation()
		{
			itemId = $"BaseItem_{itemName}";
		}
		public abstract void UseItem();
    }
}
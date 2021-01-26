//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel
{
    public class Item_Object : MonoBehaviour, IInteractable
    {
    	#region Variables
    	//References
        [SerializeField] private Item_Data thisItem;

		public void Interact()
		{
			Debug.Log($"You are interacting with {thisItem.ItemId}");
		}
		//Variables

		//Properties
		#endregion

		#region Unity Methods

		#endregion
	}
}

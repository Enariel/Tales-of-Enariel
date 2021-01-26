//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel
{
    public class Item_Database : MonoBehaviour
    {
		#region Variables
		//References
		private static Item_Database _instance;
		[SerializeField] private Player_Controller input;
		//Variables
		[SerializeField] private List<Item_Data> items;
		[SerializeField] private List<Consumable_Data> consumables;

		//Properties
		public static Item_Database Instance
		{
			get { return _instance; }
		}
		#endregion

		#region Unity Methods
		private void Awake()
		{
			//Singleton pattern
			if (_instance != null && _instance != this.gameObject)
			{
				Destroy(this.gameObject);
			}
			else
			{
				_instance = this;
			}

			input = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
		}

		private void Update()
		{
			if (input.UseInput.ReadValue<float>() > 0)
			{
				foreach (Item_Data item in items)
				{
					item.UseItem();
				}
			}
		}
		#endregion
	}
}

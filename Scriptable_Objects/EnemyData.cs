//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections.Generic;
using UnityEngine;
using Tales_Of_Enariel.Inventory;

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
	[CreateAssetMenu(fileName = "Enemy Data", menuName = "Entities/Enemy")]
	public class EnemyData : EntityData
	{
		#region Enemy Variables
		//List of possible attacks they can use
		//Drop table
		[SerializeField] private List<ItemData> oneStarDrops = new List<ItemData>();
		[SerializeField] private List<ItemData> twoStarDrops = new List<ItemData>();
		[SerializeField] private List<ItemData> threeStarDrops = new List<ItemData>();
		#endregion
	}
}

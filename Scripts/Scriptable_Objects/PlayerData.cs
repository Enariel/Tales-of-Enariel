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
	[CreateAssetMenu(fileName = "Player Data", menuName = "Entities/Player")]
	public class PlayerData : EntityData
	{
		#region Player Variables
		#endregion

		//This should mostly do nothing, as the player shouldn't be able to iteract with themselves.
		public override void Interact()
		{
			base.Interact();
		}
	}
}

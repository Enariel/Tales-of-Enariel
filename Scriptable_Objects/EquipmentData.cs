//copyright(c) FuchsFarbe
//Author: Oliver

using UnityEngine;

namespace Tales_Of_Enariel.Inventory
{
	[CreateAssetMenu(fileName = "New Equipment", menuName = "Item/Equipment")]
	public partial class EquipmentData : ItemData
	{
		#region Variables
		//Variables
		[SerializeField] private EquipmentSlot equipSlot;
		[SerializeField] private int modHP, modPhyr, modStam, modDef, modInt, modStr, modDex, modMoveSpeed, modJump;
		//Properties
		public int HpMod { get => modHP; }
		public int PhyrMod { get => modPhyr; }
		public int StamMod { get => modStam; }
		public int StrMod { get => modStr; }
		public int IntMod { get => modInt; }
		public int DexMod { get => modDex; }
		public int DefMod { get => modDef; }
		public int MoveMod { get => modMoveSpeed; }
		public int JumpMod { get => modJump; }
		#endregion

		public override void UseItem()
		{
			return;
		}
	}
}
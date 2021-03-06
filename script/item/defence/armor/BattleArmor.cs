using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
	public class BattleArmor : BaseArmor
	{
		public override string Name { get { return "Battle Armor"; } }

		public override int DamBase { get { return 0; } }
		public override int ACBase { get { return 128; } }

		public override int StrReq { get { return 401; } }
		public override int DexReq { get { return 0; } }

		public override int InitMinHits { get { return 880; } }
		public override int InitMaxHits { get { return 880; } }

       		public override int APStage { get { return 2; } }
        
        	public override int BuyPrice { get { return 100000; } }
       		public override int SellPrice { get { return 50000; } }

		public override Class ClassReq { get { return 0; } }
		public override ArmorType ArmorType { get { return ArmorType.Armor; } }

		public BattleArmor() : base (5)
		{
		}

		public BattleArmor(Serial serial) : base (serial)
		{
		}
	}
}

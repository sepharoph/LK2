using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
	public class ScaleMail : BaseArmor
	{
		public override string Name { get { return "Scale Mail"; } }

		public override int DamBase { get { return 0; } }
		public override int ACBase { get { return 165; } }

		public override int StrReq { get { return 513; } }
		public override int DexReq { get { return 146; } }

		public override int InitMinHits { get { return 1100; } }
		public override int InitMaxHits { get { return 1100; } }
		
		public override int BuyPrice { get { return 160000; } }
       		public override int SellPrice { get { return 80000; } }

       		public override int APStage { get { return 3; } }

		public override Class ClassReq { get { return 0; } }
		public override ArmorType ArmorType { get { return ArmorType.Armor; } }

		public ScaleMail() : base (5)
		{
		}

		public ScaleMail(Serial serial) : base (serial)
		{
		}
	}
}

using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
	public class Robe : BaseArmor
	{
		public override string Name { get { return "Robe"; } }

		public override int DamBase { get { return 0; } }
		public override int ACBase { get { return 82; } }

		public override int StrReq { get { return 220; } }
		public override int DexReq { get { return 0; } }

		public override int InitMinHits { get { return 520; } }
		public override int InitMaxHits { get { return 520; } }
       		
       		public override int BuyPrice { get { return 150000; } }
       		public override int SellPrice { get { return 75000; } }
       		
        	public override int APStage { get { return 1; } } 

		public override Class ClassReq { get { return 0; } }
		public override ArmorType ArmorType { get { return ArmorType.Armor; } }

		public Robe() : base (5)
		{
		}

		public Robe(Serial serial) : base (serial)
		{
            m_ItemID = 5;
		}
	}
}

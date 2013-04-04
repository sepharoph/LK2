using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
	public class FullPlate : BaseArmor
	{
		public override string Name { get { return "Full Plate"; } }

		public override int DamBase { get { return 0; } }
		public override int ACBase { get { return 228; } }

		public override int StrReq { get { return 714; } }
		public override int DexReq { get { return 0; } }

		public override int InitMinHits { get { return 1500; } }
		public override int InitMaxHits { get { return 1500; } }

        public override int APStage { get { return 3; } }

		public override Class ClassReq { get { return 0; } }
		public override ArmorType ArmorType { get { return ArmorType.Armor; } }

		public FullPlate() : base (5)
		{
		}

		public FullPlate(Serial serial) : base (serial)
		{
		}
	}
}
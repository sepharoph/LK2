using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class BraveAmulet : BaseArmor
    {
        public override string Name { get { return "Brave Amulet"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }
// adds 100max MP
// adds 50 HIT+DODGE
        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int LevelReq { get { return 75; } }

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 8000; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Amulet; } }

        public BraveAmulet()
            : base(2)
        {
        }

        public BraveAmulet(Serial serial)
            : base(serial)
        {
        }
    }
}

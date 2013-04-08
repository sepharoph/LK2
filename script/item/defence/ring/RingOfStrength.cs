using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfStrength : BaseArmor
    {
        public override string Name { get { return "Ring of Strength"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 75; } }
        public override int InitPlusStr { get { return 25; } }//adds 25Str

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 8000; } }
        public override int SellPrice { get { return 200000; } }

        public override Class ClassReq { get { return 240; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfStrength()
            : base(1)
        {
        }

        public RingOfStrength(Serial serial)
            : base(serial)
        {
        }
    }
}

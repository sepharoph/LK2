using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfVitality : BaseArmor
    {
        public override string Name { get { return "Ring of Vitality"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 150; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 8000; } }

        public override Class ClassReq { get { return 40; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfVitality()
            : base(1)
        {
        }

        public RingOfVitality(Serial serial)
            : base(serial)
        {
        }
    }
}

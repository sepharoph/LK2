using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfDexterity : BaseArmor
    {
        public override string Name { get { return "Ring of Dexterity"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 75; } }
        public override int InitPlusDex { get { return 25; } }//adds 25Dex

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 8000; } }

        public override Class ClassReq { get { return 240; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfDexterity()
            : base(1)
        {
        }

        public RingOfDexterity(Serial serial)
            : base(serial)
        {
        }
    }
}

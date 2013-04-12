using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfTheBarbarian : BaseArmor
    {
        public override string Name { get { return "RING OF THE BARBARIAN"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int StrBonus { get { return 36; } }//adds 36Str

/*Actoz intended random chance for 32-40 STR added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfTheBarbarian()
            : base(2)
        {
        }

        public RingOfTheBarbarian(Serial serial)
            : base(serial)
        {
        }
    }
}

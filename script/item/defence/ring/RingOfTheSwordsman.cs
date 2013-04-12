using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfTheSwordsman : BaseArmor
    {
        public override string Name { get { return "RING OF THE SWORDSMAN"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int StrBonus { get { return 62; } }//adds 62Str

/*Actoz intended random chance for 61-65 STR added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfTheSwordsman()
            : base(2)
        {
        }

        public RingOfTheSwordsman(Serial serial)
            : base(serial)
        {
        }
    }
}

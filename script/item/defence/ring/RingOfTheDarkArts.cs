using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfTheDarkArts : BaseArmor
    {
        public override string Name { get { return "RING OF THE DARK ARTS"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int MenBonus { get { return 26; } }//adds 26Men

/*Actoz intended random chance for 26-30 Men added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfTheDarkArts()
            : base(2)
        {
        }

        public RingOfTheDarkArts(Serial serial)
            : base(serial)
        {
        }
    }
}

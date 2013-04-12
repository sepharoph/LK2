using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfMentality : BaseArmor
    {
        public override string Name { get { return "RING OF MENTALITY"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int MenBonus { get { return 4; } }//adds 4Men

/*Actoz intended random chance for 1-5 Men added when this item dropped 
per documentation, but was probably unable to code it. so they made it add 4*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfMentality()
            : base(2)
        {
        }

        public RingOfMentality(Serial serial)
            : base(serial)
        {
        }
    }
}

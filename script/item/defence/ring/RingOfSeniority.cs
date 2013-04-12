using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfSeniority : BaseArmor
    {
        public override string Name { get { return "RING OF SENIORITY"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int VitBonus { get { return 42; } }//adds 42Vit

/*Actoz intended random chance for 41-45 Vit added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfSeniority()
            : base(2)
        {
        }

        public RingOfSeniority(Serial serial)
            : base(serial)
        {
        }
    }
}

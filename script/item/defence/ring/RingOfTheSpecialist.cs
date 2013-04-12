using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfSpecialist : BaseArmor
    {
        public override string Name { get { return "RING OF SPECIALIST"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int DexBonus { get { return 52; } }//adds 52Dex

/*Actoz intended random chance for 51-55 Dex added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfSpecialist()
            : base(2)
        {
        }

        public RingOfSpecialist(Serial serial)
            : base(serial)
        {
        }
    }
}

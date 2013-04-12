using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class RingOfActivity : BaseArmor
    {
        public override string Name { get { return "RING OF ACTIVITY"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 0; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int VitBonus { get { return 16; } }//adds 16Vit

/*Actoz intended random chance for 16-20 Vit added when this item dropped 
per documentation, but was probably unable to code it.*/

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 800; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public RingOfActivity()
            : base(2)
        {
        }

        public RingOfActivity(Serial serial)
            : base(serial)
        {
        }
    }
}

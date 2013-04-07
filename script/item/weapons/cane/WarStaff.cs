using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class WarStaff : BaseWeapon
    {
        public override string Name { get { return "War Staff"; } }

        public override int DamBase { get { return 146; } }
        public override int ACBase { get { return 67; } }
//need to add to hit 89
//need to add to max mana 122        
        public override int StrReq { get { return 88; } }
        public override int MenReq { get { return 341; } }
        public override int DexReq { get { return 0; } }
        public override int ReduceCast { get { return 900; } }//updated post 1500cast speed

        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 25000; } }
        public override int SellPrice { get { return 12500; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane2; } }

        public WarStaff()
            : base(33)
        {
        }

        public WarStaff(Serial serial)
            : base(serial)
        {
        }
    }
}

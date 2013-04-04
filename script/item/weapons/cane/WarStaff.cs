using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class WarStaff : BaseWeapon
    {
        public override string Name { get { return "War Staff"; } }

        public override int DamBase { get { return 146; } }
        public override int ACBase { get { return 67; } }

        public override int StrReq { get { return 88; } }
        public override int MenReq { get { return 341; } }
        public override int DexReq { get { return 0; } }
        public override int ReduceCast { get { return 300; } }

        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 5000; } }

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

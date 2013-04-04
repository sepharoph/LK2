using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Javelin : BaseWeapon
    {
        public override string Name { get { return "Javelin"; } }

        public override int DamBase { get { return 145; } }
        public override int ACBase { get { return 45; } }

        public override int StrReq { get { return 116; } }
        public override int MenReq { get { return 270; } }
        public override int DexReq { get { return 0; } }
        public override int ReduceCast { get { return 300; } }
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear2; } }

        public Javelin()
            : base(35)
        {
        }

        public Javelin(Serial serial)
            : base(serial)
        {
        }
    }
}

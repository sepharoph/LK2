using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class ForkedSpear : BaseWeapon
    {
        public override string Name { get { return "Forked Spear"; } }

        public override int DamBase { get { return 106; } }
        public override int ACBase { get { return 99; } }

        public override int StrReq { get { return 169; } }
        public override int MenReq { get { return 381; } }
        public override int DexReq { get { return 243; } }
        public override int ReduceCast { get { return 800; } }
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public ForkedSpear()
            : base(35)
        {
        }

        public ForkedSpear(Serial serial)
            : base(serial)
        {
        }
    }
}

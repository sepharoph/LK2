using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Harpoon : BaseWeapon
    {
        public override string Name { get { return "Harpoon"; } }

        public override int DamBase { get { return 69; } }
        public override int ACBase { get { return 55; } }

        public override int StrReq { get { return 102; } }
        public override int MenReq { get { return 231; } }
        public override int DexReq { get { return 141; } }
        public override int ReduceCast { get { return 300; } }
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public Harpoon()
            : base(34)
        {
        }

        public Harpoon(Serial serial)
            : base(serial)
        {
        }
    }
}

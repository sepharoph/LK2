using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Wand : BaseWeapon
    {
        public override string Name { get { return "Wand"; } }

        public override int DamBase { get { return 132; } }
        public override int ACBase { get { return 98; } }

        public override int StrReq { get { return 106; } }
        public override int MenReq { get { return 420; } }
        public override int DexReq { get { return 131; } }
        public override int ReduceCast { get { return 300; } }
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane; } }

        public Wand()
            : base(33)
        {
        }

        public Wand(Serial serial)
            : base(serial)
        {
        }
    }
}

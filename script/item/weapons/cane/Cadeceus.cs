using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Cadeceus : BaseWeapon
    {
        public override string Name { get { return "Cadeceus"; } }

        public override int DamBase { get { return 91; } }
        public override int ACBase { get { return 0; } }
        public override int InitMaxMana { get { return 220; } }//add max mana plz approve!!

        public override int StrReq { get { return 125; } }
        public override int MenReq { get { return 512; } }
        public override int DexReq { get { return 0; } }
        public override int ReduceCast { get { return 1100; } }
        public override int LevelReq { get { return 160; } }//reflects item is for 3rd promo
        
        public override int InitMinHits { get { return 0; } }//Doesn't add HIT
        public override int InitMaxHits { get { return 0; } }//Doesn't add HIT
        public override int BuyPrice { get { return 250000; } }
        public override int SellPrice { get { return 150000; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane2; } }

        public Cadeceus()
            : base(33)
        {
        }

        public Cadeceus(Serial serial)
            : base(serial)
        {
        }
    }
}

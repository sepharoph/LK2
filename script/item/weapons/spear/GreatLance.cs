using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class GreatLance : BaseWeapon
    {
        public override string Name { get { return "Great Lance"; } }

        public override int DamBase { get { return 182; } }
        public override int ACBase { get { return 120; } }
        public override int InitMaxMana { get { return 189; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 190; } }
        public override int MenReq { get { return 425; } }
        public override int DexReq { get { return 0; } }
        public override int LevelReq { get { return 100; } }//reflects item is for 1st promo
        
        public override int ReduceCast { get { return 1000; } }//10 dec time
        public override int InitMinHits { get { return 0; } }//adds 0 HIT
        public override int InitMaxHits { get { return 0; } }//adds 0 HIT
        public override int BuyPrice { get { return 200000; } }
        public override int SellPrice { get { return 100000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear2; } }

        public GreatLance()
            : base(35)
        {
        }

        public GreatLance(Serial serial)
            : base(serial)
        {
        }
    }
}

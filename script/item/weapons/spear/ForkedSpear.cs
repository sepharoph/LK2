using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class ForkedSpear : BaseWeapon
    {
        public override string Name { get { return "Forked Spear"; } }

        public override int DamBase { get { return 106; } }
        public override int ACBase { get { return 99; } }
        public override int InitMaxMana { get { return 102; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 169; } }
        public override int MenReq { get { return 381; } }
        public override int DexReq { get { return 243; } }
        public override int LevelReq { get { return 100; } }//reflects item is for 3rd promo
        
        public override int ReduceCast { get { return 1100; } }
        public override int InitMinHits { get { return 0; } }//adds 0 hit
        public override int InitMaxHits { get { return 0; } }//adds 0 hit
        public override int BuyPrice { get { return 200000; } }
        public override int SellPrice { get { return 100000; } }

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

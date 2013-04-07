using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Crook : BaseWeapon
    {
        public override string Name { get { return "Crook"; } }

        public override int DamBase { get { return 66; } }
        public override int ACBase { get { return 44; } }
        public override int InitMaxMana { get { return 65; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 33; } }
        public override int MenReq { get { return 152; } }
        public override int DexReq { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        
        public override int ReduceCast { get { return 600; } }
        public override int InitMinHits { get { return 0; } }//adds 0 hit
        public override int InitMaxHits { get { return 0; } }//adds 0 hit
        public override int BuyPrice { get { return 100000; } }
        public override int SellPrice { get { return 50000; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane; } }

        public Crook()
            : base(32)
        {
        }

        public Crook(Serial serial)
            : base(serial)
        {
            m_ItemID = 32;
        }
    }
}

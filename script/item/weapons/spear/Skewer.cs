using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Skewer : BaseWeapon
    {
        public override string Name { get { return "Skewer"; } }

        public override int DamBase { get { return 94; } }
        public override int ACBase { get { return 35; } }
        public override int InitMaxMana { get { return 56; } }//add max mana plz approve!!

        public override int StrReq { get { return 54; } }
        public override int MenReq { get { return 120; } }
        public override int DexReq { get { return 0; } }
        
        public override int ReduceCast { get { return 600; } }
        public override int InitMinHits { get { return 44; } }//adds 44 HIT
        public override int InitMaxHits { get { return 44; } }//adds 44 HIT
        public override int BuyPrice { get { return 100000; } }
        public override int SellPrice { get { return 50000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public Skewer()
            : base(34)
        {
        }

        public Skewer(Serial serial)
            : base(serial)
        {
            m_ItemID = 34;
        }
    }
}

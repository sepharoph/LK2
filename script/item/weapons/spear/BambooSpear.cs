using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class BambooSpear : BaseWeapon
    {
        public override string Name { get { return "Bamboo Spear"; } }

        public override int DamBase { get { return 25; } }
        public override int ACBase { get { return 10; } }
        public override int InitMaxMana { get { return 24; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 21; } }
        public override int MenReq { get { return 42; } }
        public override int DexReq { get { return 0; } }
        public override int ReduceCast { get { return 200; } }//set to 2 dec time

        public override int InitMinHits { get { return 5; } }//adds 5 HIT
        public override int InitMaxHits { get { return 5; } }//adds 5 HIT
        public override int BuyPrice { get { return 4000; } }
        public override int SellPrice { get { return 2000; } }//added a sell price of half expected value

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public BambooSpear()
            : base(34)
        {
        }

        public BambooSpear(Serial serial)
            : base(serial)
        {
            m_ItemID = 34;
        }
    }
}

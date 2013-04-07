using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class TaegkFan : BaseWeapon
    {
        public override string Name { get { return "Taegk Fan"; } }

        public override int DamBase { get { return 160; } }
        public override int ACBase { get { return 160; } }
        public override int InitMaxMana { get { return 400; } }//add max mana plz approve!!
       
        public override int StrReq { get { return 250; } }
        public override int MenReq { get { return 5500; } }
        public override int DexReq { get { return 4500; } }
        public override int LevelReq { get { return 240; } }//reflects for 7th promotion
        
        public override int ReduceCast { get { return 1150; } }
        
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear2; } }

        public TaegkFan()
            : base(35)
        {
        }

        public TaegkFan(Serial serial)
            : base(serial)
        {
        }
    }
}

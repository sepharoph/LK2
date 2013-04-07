using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class AngelicArmor : BaseArmor
    {
        public override string Name { get { return "ANGELIC ARMOR"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 190; } }

        public override int DexBonus { get { return 50; } }//adds 25Dex
        public override int MenBonus { get { return 100; } }//adds 50Men

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 2500; } }
        public override int MenReq { get { return 5000; } }

        public override int InitMinHits { get { return 300; } }
        public override int InitMaxHits { get { return 300; } }
        public override int InitMaxMana { get { return 100; } }

        public override int APStage { get { return 4; } }

        public override int LevelReq { get { return 240; } }
        public override Class ClassReq { get { return Class.Wizard | Class.Shaman; } }
        public override ArmorType ArmorType { get { return ArmorType.Armor; } }

        public AngelicArmor()
            : base(8)
        {
        }

        public AngelicArmor(Serial serial)
            : base(serial)
        {
        }
    }
}

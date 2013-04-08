using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class CelestialArmor : BaseArmor
    {
        public override string Name { get { return "CELESTIAL ARMOR"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 165; } }

        public override int DexBonus { get { return 25; } }//adds 25Dex
        public override int MenBonus { get { return 50; } }//adds 50Men

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 2500; } }
        public override int MenReq { get { return 5000; } }

        public override int InitMinHits { get { return 300; } }
        public override int InitMaxHits { get { return 300; } }
        public override int InitMaxMana { get { return 100; } }
        
        public override int BuyPrice { get { return 900000; } }
        public override int SellPrice { get { return 400000; } }

        public override int APStage { get { return 3; } }//Stage 4, need Sprite

        public override int LevelReq { get { return 200; } }
        public override Class ClassReq { get { return Class.Wizard | Class.Shaman; } }
        public override ArmorType ArmorType { get { return ArmorType.Armor; } }

        public CelestialArmor()
            : base(8)
        {
        }

        public CelestialArmor(Serial serial)
            : base(serial)
        {
        }
    }
}

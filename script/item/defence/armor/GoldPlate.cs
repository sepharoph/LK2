﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class GoldPlate : BaseArmor
    {
        public override string Name { get { return "Gold Plate"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 300; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 300; } }
        public override int InitMaxHits { get { return 300; } }

        public override int APStage { get { return 4; } }

        public override int LevelReq { get { return 100; } }
        public override Class ClassReq { get { return Class.Knight; } }
        public override ArmorType ArmorType { get { return ArmorType.Armor; } }

        public GoldPlate()
            : base(8)
        {
        }

        public GoldPlate(Serial serial)
            : base(serial)
        {
        }
    }
}

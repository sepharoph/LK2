﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class GoliathPlate : BaseArmor
    {
        public override string Name { get { return "GOLIATH PLATE"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 345; } }

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 300; } }
        public override int InitMaxHits { get { return 300; } }

        public override int APStage { get { return 4; } }

        public override int LevelReq { get { return 140; } }
        public override Class ClassReq { get { return Class.Knight | Class.Swordsman; } }
        public override ArmorType ArmorType { get { return ArmorType.Armor; } }

        public GoliathPlate()
            : base(8)
        {
        }

        public GoliathPlate(Serial serial)
            : base(serial)
        {
        }
    }
}

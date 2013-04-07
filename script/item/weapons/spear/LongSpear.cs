﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class LongSpear : BaseWeapon
    {
        public override string Name { get { return "Long Spear"; } }

        public override int DamBase { get { return 88; } }
        public override int ACBase { get { return 55; } }

        public override int StrReq { get { return 70; } }
        public override int MenReq { get { return 165; } }
        public override int DexReq { get { return 106; } }
        
        public override int ReduceCast { get { return 700; } }// 7 dec time
        public override int InitMinHits { get { return 63; } }//adds 63 HIT
        public override int InitMaxHits { get { return 63; } }//adds 63 HIT
        public override int BuyPrice { get { return 75000; } }
        public override int SellPrice { get { return 37500; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public LongSpear()
            : base(34)
        {
        }

        public LongSpear(Serial serial)
            : base(serial)
        {
        }
    }
}

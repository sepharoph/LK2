﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Calypso : BaseWeapon
    {
        public override string Name { get { return "Calypso"; } }

        public override int DamBase { get { return 160; } }
        public override int ACBase { get { return 130; } }

        public override int StrReq { get { return 180; } }
        public override int MenReq { get { return 650; } }
        public override int DexReq { get { return 0; } }
        public override int LevelReq { get { return 220; } }//updated to reflect item is for 6th promo
        
        public override int InitMinHits { get { return 0; } }//Doesn't Add HIT
        public override int InitMaxHits { get { return 0; } }//Doesn't Add HIT
        public override int BuyPrice { get { return 5000; } }
        public override int ReduceCast { get { return 1100; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane2; } }

        public Calypso()
            : base(33)
        {
        }

        public Calypso(Serial serial)
            : base(serial)
        {
        }
    }
}

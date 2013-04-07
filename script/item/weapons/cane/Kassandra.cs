﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Kassandra : BaseWeapon
    {
        public override string Name { get { return "Kassandra"; } }

        public override int DamBase { get { return 150; } }
        public override int ACBase { get { return 170; } }

        public override int StrReq { get { return 200; } }
        public override int MenReq { get { return 4500; } }
        public override int DexReq { get { return 5500; } }
        public override int LevelReq { get { return 240; } }//reflects for 7th promo

        public override int InitMinHits { get { return 150; } }
        public override int InitMaxHits { get { return 150; } }//reflects +150hit for while item equipped
        
        public override int BuyPrice { get { return 5000; } }
        public override int ReduceCast { get { return 1150; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane2; } }

        public Kassandra()
            : base(33)
        {
        }

        public Kassandra(Serial serial)
            : base(serial)
        {
        }
    }
}

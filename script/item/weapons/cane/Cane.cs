﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Cain : BaseWeapon
    {
        public override string Name { get { return "Cain"; } }

        public override int DamBase { get { return 52; } }
        public override int ACBase { get { return 0; } }
        public override int InitMaxMana { get { return 99; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 55; } }
        public override int MenReq { get { return 245; } }
        public override int DexReq { get { return 62; } }
        public override int LevelReq { get { return 36; } }
        
        
        public override int ReduceCast { get { return 900; } }
        public override int InitMinHits { get { return 36; } }//adds 36 hit
        public override int InitMaxHits { get { return 36; } }//adds 36 hit
        public override int BuyPrice { get { return 5000; } }

        public override Class ClassReq { get { return Class.Wizard; } }
        public override WeaponType WeaponType { get { return WeaponType.Cane; } }

        public Cain()
            : base(32)
        {
        }

        public Cain(Serial serial)
            : base(serial)
        {
        }
    }
}

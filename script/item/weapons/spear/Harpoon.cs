﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class Harpoon : BaseWeapon
    {
        public override string Name { get { return "Harpoon"; } }

        public override int DamBase { get { return 69; } }
        public override int ACBase { get { return 64; } }
        public override int InitMaxMana { get { return 73; } }//add max mana plz approve!!
        
        public override int StrReq { get { return 102; } }
        public override int MenReq { get { return 231; } }
        public override int DexReq { get { return 141; } }
        public override int LevelReq { get { return 48; } }//reflects item
        
        public override int ReduceCast { get { return 900; } }// 9 dec time
        public override int InitMinHits { get { return 80; } }
        public override int InitMaxHits { get { return 80; } }
        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }

        public override Class ClassReq { get { return Class.Shaman; } }
        public override WeaponType WeaponType { get { return WeaponType.Spear; } }

        public Harpoon()
            : base(34)
        {
        }

        public Harpoon(Serial serial)
            : base(serial)
        {
        }
    }
}

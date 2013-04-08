﻿using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
    public class SRing : BaseArmor
    {
        public override string Name { get { return "S-RING"; } }

        public override int DamBase { get { return 0; } }
        public override int ACBase { get { return 250; } }//spoke w/ XLN definetly *ONLY* gave 250AC

        public override int StrReq { get { return 0; } }
        public override int DexReq { get { return 0; } }

        public override int InitMinHits { get { return 65; } }
        public override int InitMaxHits { get { return 65; } }
        public override int BuyPrice { get { return 8000; } }

        public override Class ClassReq { get { return 0; } }
        public override ArmorType ArmorType { get { return ArmorType.Ring; } }

        public SRing()
            : base(1)
        {
        }

        public SRing(Serial serial)
            : base(serial)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.item.potions
{
    public class FullMagicDrug : BasePotion
    {
        public override string Name { get { return "Full Magic Drug"; } }
        public override int BuyPrice { get { return 500; } }
        public override int SellPrice { get { return 250; } }

        public FullMagicDrug() : base(23)
        {
        }

        public FullMagicDrug(Serial serial) : base(serial)
        {
            m_ItemID = 23;
        }

        public override void Use(Player player)
        {
            player.MPCur = player.MP;
            base.Use(player);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.item.potions
{
    public class LifeDrug : BasePotion
    {
        public override string Name { get { return "Life Drug"; } }
        public override int BuyPrice { get { return 250; } }
        public override int SellPrice { get { return 125; } }

        public LifeDrug()
            : base(20)
        {
        }

        public LifeDrug(Serial serial)
            : base(serial)
        {
            m_ItemID = 20;
        }

        public override void Use(Player player)
        {
            player.HPCur += player.HP / 2;
            base.Use(player);
        }
    }
}

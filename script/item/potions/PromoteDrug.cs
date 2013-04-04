using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.item.potions
{
    public class PromoteLifeDrug : BasePotion
    {
        public override string Name { get { return "Promote Life Drug"; } }
        public override int BuyPrice { get { return 5000; } }

        public PromoteLifeDrug()
            : base(22)
        {
        }

        public PromoteLifeDrug(Serial serial)
            : base(serial)
        {
            m_ItemID = 22;
        }
    }
}

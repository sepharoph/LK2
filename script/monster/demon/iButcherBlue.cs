using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.monster
{
    public class iButcherBlue : Monster
    {
        public override string Name { get { return "Butcher"; } }
        public override int HP { get { return 130; } }

        public override int AC { get { return 57; } }
        public override int Hit { get { return 85; } }
        public override int Dam { get { return 65; } }

        public override int XP { get { return 369; } }
        public override int Color { get { return 3; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d12+150", 40, 1, 1),
                });
            }
        }

        public iButcherBlue()
            : base(8)
        {
        }

        public iButcherBlue(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 8;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public iButcherBlue(Serial serial)
            : base(serial)
        {
        }
    }
}

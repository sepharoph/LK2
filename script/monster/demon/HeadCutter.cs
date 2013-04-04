using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.monster
{
    public class HeadCutter : Monster
    {
        public override string Name { get { return "Head Cutter"; } }
        public override int HP { get { return 150; } }
        public override int Dam { get { return 26; } }
        public override int AC { get { return 28; } }
        public override int Hit { get { return 57; } }
        public override int XP { get { return 78; } }
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d10+100", 40, 1, 1),
                });
            }
        }

        public HeadCutter()
            : base(30)
        {
        }

        public HeadCutter(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 30;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public HeadCutter(Serial serial)
            : base(serial)
        {
        }
    }
}

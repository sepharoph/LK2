using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.model;
namespace LKCamelot.script.monster
{
    public class SkelGiant : Monster
    {
        public override string Name { get { return "Skel Giant"; } }
        public override int HP { get { return 30000; } }//updated
        public override int Dam { get { return 2500; } }//updated
        public override int AC { get { return 5000; } }//updated
        public override int Hit { get { return 5900; } }//updated
        public override int XP { get { return 100000; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Undead; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public SkelGiant()
            : base(26)
        {
        }

        public SkelGiant(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 26;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public SkelGiant(Serial serial)
            : base(serial)
        {
        }
    }

    public class Gargoyle : Monster
    {
        public override string Name { get { return "Gargoyle"; } }
        public override int HP { get { return 32500; } }//updated
        public override int Dam { get { return 3250; } }//updated
        public override int AC { get { return 4250; } }//updated
        public override int Hit { get { return 5000; } }//updated
        public override int XP { get { return 350000; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public Gargoyle()
            : base(204)
        {
        }

        public Gargoyle(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 204;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public Gargoyle(Serial serial)
            : base(serial)
        {
        }
    }

    public class Ninja : Monster
    {
        public override string Name { get { return "Ninja"; } }
        public override int HP { get { return 35000; } }//updated
        public override int Dam { get { return 3500; } }//updated
        public override int AC { get { return 4500; } }//updated
        public override int Hit { get { return 5250; } }//updated
        public override int XP { get { return 350000; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public Ninja()
            : base(213)
        {
        }

        public Ninja(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 213;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public Ninja(Serial serial)
            : base(serial)
        {
        }
    }

    public class Necromancer : Monster
    {
        public override string Name { get { return "Necromancer"; } }
        public override int HP { get { return 37500; } }//updated
        public override int Dam { get { return 3750; } }//updated
        public override int AC { get { return 4750; } }//updated
        public override int Hit { get { return 5500; } }//updated
        public override int XP { get { return 350000; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public Necromancer()
            : base(205)
        {
        }

        public Necromancer(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 205;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public Necromancer(Serial serial)
            : base(serial)
        {
        }
    }

    public class LoupGarou : Monster
    {
        public override string Name { get { return "Loup Garou"; } }
        public override int HP { get { return 40000; } }//updated
        public override int Dam { get { return 4000; } }//updated
        public override int AC { get { return 5000; } }//updated
        public override int Hit { get { return 5750; } }//updated
        public override int XP { get { return 350000; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Undead; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public LoupGarou()
            : base(208)
        {
        }

        public LoupGarou(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 208;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public LoupGarou(Serial serial)
            : base(serial)
        {
        }
    }

    public class GhostKnight : Monster
    {
        public override string Name { get { return "Ghost Knight"; } }
        public override int HP { get { return 42500; } }//updated
        public override int Dam { get { return 4250; } }//updated
        public override int AC { get { return 7000; } }//updated
        public override int Hit { get { return 6000; } }//updated
        public override int XP { get { return 666670; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.001, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.001, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public GhostKnight()
            : base(207)
        {
        }

        public GhostKnight(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 207;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public GhostKnight(Serial serial)
            : base(serial)
        {
        }
    }

    public class DevilGuard : Monster
    {
        public override string Name { get { return "Devil Guard"; } }
        public override int HP { get { return 45000; } }//updated
        public override int Dam { get { return 4750; } }//updated
        public override int AC { get { return 7250; } }//updated
        public override int Hit { get { return 6250; } }//updated
        public override int XP { get { return 666670; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(0.01, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.01, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.0001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(0.1, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public DevilGuard()
            : base(211)
        {
        }

        public DevilGuard(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 211;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public DevilGuard(Serial serial)
            : base(serial)
        {
        }
    }

    public class Devil : Monster
    {
        public override string Name { get { return "Devil"; } }
        public override int HP { get { return 50000; } }//updated
        public override int Dam { get { return 5000; } }//updated
        public override int AC { get { return 7500; } }//updated
        public override int Hit { get { return 6500; } }//updated
        public override int XP { get { return 666670; } }//updated
        public override int Color { get { return 0; } }
        public override int SpawnTime { get { return 30000; } }
        public override Race Race { get { return Race.Demon; } }

        public override LootPack Loot
        {
            get
            {
                return new LootPack(new LootPackEntry[]
                {
                    new LootPackEntry(.01, typeof(script.item.UnicornProtectoria), "10d22+250", 40, 1, 1),
                    new LootPackEntry(.01, typeof(script.item.HolyDefender), "10d22+250", 40, 1, 1),
                    new LootPackEntry(.01, typeof(script.item.GrandeurPride), "10d22+250", 40, 1, 1),
                  // Best Armor  new LootPackEntry(0.001, typeof(script.item.), "10d22+250", 40, 1, 1),
                //Best Armor    new LootPackEntry(0.001, typeof(script.item.), "10d22+250", 40, 1, 1),
                    new LootPackEntry(1, typeof(script.item.Excalibur), "10d22+250", 40, 1, 1),
                    new LootPackEntry(1, typeof(script.item.DaeungDaegum), "10d22+250", 40, 1, 1),
                    new LootPackEntry(1, typeof(script.item.Kassandra), "10d22+250", 40, 1, 1),
                    new LootPackEntry(1, typeof(script.item.TaegkFan), "10d22+250", 40, 1, 1),
                    new LootPackEntry(2.5, typeof(script.item.TomaHawk), "10d22+250", 40, 1, 1),
                    new LootPackEntry(2.5, typeof(script.item.GiantHammer), "10d22+250", 40, 1, 1),
                    new LootPackEntry(5, typeof(script.item.SRing), "10d22+250", 40, 1, 1),
                    new LootPackEntry(5, typeof(script.item.SAmulet), "10d22+250", 40, 1, 1),
                    new LootPackEntry(15.0, typeof(script.item.Gold), "10d30+55000", 40, 1, 1),
                });
            }
        }

        public Devil()
            : base(212)
        {
        }

        public Devil(Serial temp, int x, int y, string map)
            : this(temp)
        {
            m_MonsterID = 212;
            m_Loc = new Point2D(x, y);
            m_SpawnLoc = new Point2D(m_Loc.X, m_Loc.Y);
            m_Map = map;
            m_Serial = temp;
        }

        public Devil(Serial serial)
            : base(serial)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LKCamelot.library;
using LKCamelot.model;
namespace LKCamelot.script.item
{
    public class BaseSpellbook : Item
    {
        public virtual int MenReqPl { get { return 0; } }
        public virtual int DexReqPl { get { return 0; } }

        public virtual int LevelReqPl { get { return 0; } }

        public virtual spells.Spell SpellTaught { get { return null; } }

        public BaseSpellbook(int itemID) : base(itemID)
        {
        }

        public BaseSpellbook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }

        public override void Use(Player player)
        {
            if (player.LearnSpell(this))
            {
                this.Delete(player);
            }
        }
    }

            public class ThunderStormBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF THUNDER STORM"; } }
        public override int MenReq { get { return 285; } }// lower requirement for spell to 285
        public override int MenReqPl { get { return 11; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int SellPrice { get { return 10000; } }// changed sell price to 10k

        public override spells.Spell SpellTaught { get { return new spells.ThunderStorm(); } }

        public ThunderStormBook()
            : base(3)
        {
        }

        public ThunderStormBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class Opening : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF Opening"; } }
        public override int MenReq { get { return 18; } }
        public override int MenReqPl { get { return 2; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 15000; } }
        public override int SellPrice { get { return 7500; } }

        public override spells.Spell SpellTaught { get { return new spells.Opening(); } }

        public OpeningBook() : base(3)
        {
        }

        public OpeningBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class StartingPointBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF STARTING POINT"; } }
        public override int MenReq { get { return 20; } }
        public override int MenReqPl { get { return 4; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 15; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 25000; } }
        public override int SellPrice { get { return 12500; } }

        public override spells.Spell SpellTaught { get { return new spells.StartingPoint(); } }

        public StartingPointBook() : base(3)
        {
        }

        public StartingPointBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }

            public class OblivionBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF OBLIVION"; } }
        public override int MenReq { get { return 34; } }
        public override int MenReqPl { get { return 8; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 25000; } }
        public override int SellPrice { get { return 12500; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.Oblivion(); } }

        public OblivionBook() : base(3)
        {
        }

        public OblivionBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
          public class SearchBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SEARCH"; } }
        public override int MenReq { get { return 27; } }
        public override int MenReqPl { get { return 6; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 10000; } }
        public override int SellPrice { get { return 5000; } }

        public override spells.Spell SpellTaught { get { return new spells.Search(); } }

        public SearchBook() : base(3)
        {
        }

        public SearchBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class IceBagBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ICE BAG"; } }
        public override int MenReq { get { return 27; } }
        public override int MenReqPl { get { return 7; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.IceBag(); } }

        public IceBagBook() : base(3)
        {
        }

        public IceBagBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
              public class ComeBackBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF COME BACK"; } }
        public override int MenReq { get { return 38; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.ComeBack(); } }

        public ComeBackBook() : base(3)
        {
        }

        public ComeBackBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            
            public class X-RayBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF X-RAY"; } }
        public override int MenReq { get { return 40; } }
        public override int MenReqPl { get { return 11; } }
        public override int DexReq { get { return 62; } }
        public override int DexReqPl { get { return 3; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.X-Ray(); } }

        public X-RayBook() : base(3)
        {
        }

        public X-RayBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class PickUpBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF PICK UP"; } }
        public override int MenReq { get { return 62; } }
        public override int MenReqPl { get { return 17; } }
        public override int DexReq { get { return 102; } }
        public override int DexReqPl { get { return 4; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.PickUp(); } }

        public PickUpBook() : base(3)
        {
        }

        public PickUpBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class ShootingStarBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SHOOTING STAR"; } }
        public override int MenReq { get { return 53; } }
        public override int MenReqPl { get { return 5; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Knight | Class.Wizard; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.ShootingStar(); } }

        public ShootingStarBook() : base(3)
        {
        }

        public ShootingStarBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class MorningStarBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MORNING STAR"; } }
        public override int MenReq { get { return 67; } }
        public override int MenReqPl { get { return 4; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Swordsman | Class.Shaman; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }

        public override spells.Spell SpellTaught { get { return new spells.MorningStar(); } }

        public MorningStarBook() : base(3)
        {
        }

        public MorningStarBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
       
            public class IceWallBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ICE WALL"; } }
        public override int MenReq { get { return 204; } }
        public override int MenReqPl { get { return 14; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard | Class.Shaman; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }

        public override spells.Spell SpellTaught { get { return new spells.IceWall(); } }

        public IceWallBook() : base(3)
        {
        }

        public IceWallBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
                
                public class TransparencyBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TRANSPARENCY"; } }
        public override int MenReq { get { return 120; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 50; } }
        public override Class ClassReq { get { return Class.Swordsman | Class.Wizard; } }

        public override int BuyPrice { get { return 100000; } }
        public override int SellPrice { get { return 50000; } }

        public override spells.Spell SpellTaught { get { return new spells.Transparency(); } }

        public TransparencyBook() : base(3)
        {
        }

        public TransparencyBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class TwinCobraBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TWIN COBRA"; } }
        public override int MenReq { get { return 60; } }
        public override int MenReqPl { get { return 18; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Knight | Class.Wizard; } }

        public override int BuyPrice { get { return 80000; } }
        public override int SellPrice { get { return 40000; } }

        public override spells.Spell SpellTaught { get { return new spells.TwinCobra(); } }

        public TwinCobraBook() : base(3)
        {
        }

        public TwinCobraBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
                public class SharpEyeBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SHARP EYE"; } }
        public override int MenReq { get { return 66; } }
        public override int MenReqPl { get { return 20; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 40; } }
        public override Class ClassReq { get { return Class.Shaman | Class.Wizard; } }

        public override int BuyPrice { get { return 75000; } }
        public override int SellPrice { get { return 37500; } }

        public override spells.Spell SpellTaught { get { return new spells.SharpEye(); } }

        public SharpEyeBook() : base(3)
        {
        }

        public SharpEyeBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class ElectronicTubeBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ELECTRONIC TUBE"; } }
        public override int MenReq { get { return 482; } }
        public override int MenReqPl { get { return 13; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman | Class.Wizard; } }

        public override int BuyPrice { get { return 60000; } }
        public override int SellPrice { get { return 30000; } }

        public override spells.Spell SpellTaught { get { return new spells.SharpEye(); } }

        public SharpEyeBook() : base(3)
        {
        }

        public SharpEyeBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class GhostHunterBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF GHOST HUNTER"; } }
        public override int MenReq { get { return 102; } }
        public override int MenReqPl { get { return 6; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 70000; } }
        public override int SellPrice { get { return 35000; } }

        public override spells.Spell SpellTaught { get { return new spells.GhostHunter(); } }

        public GhostHunterBook() : base(3)
        {
        }

        public GhostHunterBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            
            public class SoulSpriteBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SOUL SPRITE"; } }
        public override int MenReq { get { return 198; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 60000; } }
        public override int SellPrice { get { return 30000; } }

        public override spells.Spell SpellTaught { get { return new spells.SoulSprite(); } }

        public SoulSpriteBook() : base(3)
        {
        }

        public SoulSpriteBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
                public class NosebleedBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF NOSEBLEED"; } }
        public override int MenReq { get { return 225; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 60000; } }
        public override int SellPrice { get { return 30000; } }

        public override spells.Spell SpellTaught { get { return new spells.Nosebleed(); } }

        public NosebleedBook() : base(3)
        {
        }

        public NosebleedBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class StoneCurseBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF STONE CURSE"; } }
        public override int MenReq { get { return 231; } }
        public override int MenReqPl { get { return 16; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 80000; } }
        public override int SellPrice { get { return 40000; } }

        public override spells.Spell SpellTaught { get { return new spells.StoneCurse(); } }

        public StoneCurseBook() : base(3)
        {
        }

        public StoneCurseBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
                  
            public class RadiationBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF RADIATION"; } }
        public override int MenReq { get { return 250; } }
        public override int MenReqPl { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 50; } }
        public override int LevelReqPl { get { return 3; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 80000; } }
        public override int SellPrice { get { return 40000; } }

        public override spells.Spell SpellTaught { get { return new spells.Radiation(); } }

        public RadiationBook() : base(3)
        {
        }

        public RadiationBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class DeadlyMessengerBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF DEADLY MESSENGER"; } }
        public override int MenReq { get { return 336; } }
        public override int MenReqPl { get { return 9; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 80000; } }
        public override int SellPrice { get { return 40000; } }

        public override spells.Spell SpellTaught { get { return new spells.DeadlyMessenger(); } }

        public DeadlyMessengerBook() : base(3)
        {
        }

        public DeadlyMessengerBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class DragonBreathBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF DRAGON BREATH"; } }
        public override int MenReq { get { return 380; } }
        public override int MenReqPl { get { return 6; } }
        public override int DexReq { get { return 205; } }
        public override int DexReqPl { get { return 5; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 90000; } }
        public override int SellPrice { get { return 45000; } }

        public override spells.Spell SpellTaught { get { return new spells.DragonBreath(); } }

        public DragonBreathBook() : base(3)
        {
        }

        public DragonBreathBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class ElectronicBallBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ELECTRONIC BALL"; } }
        public override int MenReq { get { return 24; } }
        public override int MenReqPl { get { return 4; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 1000; } }
        public override int SellPrice { get { return 500; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.ElectronicBall(); } }

        public ElectronicBallBook() : base(3)
        {
        }

        public ElectronicBallBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class WindySpiritBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF WINDY SPIRIT"; } }
        public override int MenReq { get { return 1000; } }
        public override int MenReqPl { get { return 300; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 135; } }
        public override int LevelReqPl { get { return 5; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int SellPrice { get { return 1000000; } }// changed sell price to 1m

        public override spells.Spell SpellTaught { get { return new spells.WindySpirit(); } }

        public WindySpiritBook()
            : base(3)
        {
        }

        public WindySpiritBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }
/* Added in below Book of Flame Strike, Copied formula for Windy Sprirt changed to STR REQ*/
            public class FlameStrikeBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FLAME STRIKE"; } }
        public override int StrReq { get {return 1000; } }
        public override int StrReqPl { get { return 300; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 0; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 135; } }
        public override int LevelReqPl { get { return 5; } }
        public override Class ClassReq { get { return Class.Knight; } }

        public override int SellPrice { get { return 1000000; } }//set sellprice to 1m

        public override spells.Spell SpellTaught { get { return new spells.FlameStrike(); } }

        public FlameStrikeBook()
            : base(3)
        {
        }

        public WindySpiritBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class SmogScreenBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SMOG SCREEN"; } }
        public override int MenReq { get { return 108; } }
        public override int MenReqPl { get { return 6; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 20000; } }
        public override int SellPrice { get { return 10000; } }

        public override spells.Spell SpellTaught { get { return new spells.SmogScreen(); } }

        public SmogScreenBook() : base(3)
        {
        }

        public SmogScreenBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class ShockBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SHOCK"; } }
        public override int MenReq { get { return 127; } }
        public override int MenReqPl { get { return 13; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 30000; } }
        public override int SellPrice { get { return 15000; } }

        public override spells.Spell SpellTaught { get { return new spells.Shock(); } }

        public ShockBook() : base(3)
        {
        }

        public ShockBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
                
            public class SorcererHunterBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SORCERER HUNTER"; } }
        public override int MenReq { get { return 170; } }
        public override int MenReqPl { get { return 8; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 40000; } }
        public override int SellPrice { get { return 20000; } }

        public override spells.Spell SpellTaught { get { return new spells.SorcererHunter(); } }

        public SorcererHunterBook() : base(3)
        {
        }

        public SorcererHunterBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class EvilMindBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF EVIL MIND"; } }
        public override int MenReq { get { return 376; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }

        public override spells.Spell SpellTaught { get { return new spells.EvilMind(); } }

        public EvilMindBook() : base(3)
        {
        }

        public EvilMindBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class TornadoBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TORNADO"; } }
        public override int MenReq { get { return 390; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 60000; } }
        public override int SellPrice { get { return 30000; } }

        public override spells.Spell SpellTaught { get { return new spells.Tornado(); } }

        public TornadoBook() : base(3)
        {
        }

        public TornadoBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            public class ChaosBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF CHAOS"; } }
        public override int MenReq { get { return 408; } }
        public override int MenReqPl { get { return 8; } }
        public override int DexReq { get { return 112; } }
        public override int DexReqPl { get { return 2; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 60000; } }
        public override int SellPrice { get { return 30000; } }

        public override spells.Spell SpellTaught { get { return new spells.Chaos(); } }

        public ChaosBook() : base(3)
        {
        }

        public ChaosBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class HailStormBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF HAIL STORM"; } }
        public override int MenReq { get { return 417; } }
        public override int MenReqPl { get { return 11; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 75000; } }
        public override int SellPrice { get { return 35000; } }

        public override spells.Spell SpellTaught { get { return new spells.HailStorm(); } }

        public HailStormBook() : base(3)
        {
        }

        public HailStormBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class FreezingBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FREEZING"; } }
        public override int MenReq { get { return 340; } }
        public override int MenReqPl { get { return 25; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 80000; } }
        public override int SellPrice { get { return 40000; } }

        public override spells.Spell SpellTaught { get { return new spells.Freezing(); } }

        public FreezingBook() : base(3)
        {
        }

        public FreezingBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class FireScrewBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE SCREW"; } }
        public override int MenReq { get { return 450; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 90000; } }
        public override int SellPrice { get { return 45000; } }

        public override spells.Spell SpellTaught { get { return new spells.FireScrew(); } }

        public FireScrewBook() : base(3)
        {
        }

        public FireScrewBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            
            public class MedusaBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MEDUSA"; } }
        public override int MenReq { get { return 468; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 132; } }
        public override int DexReqPl { get { return 3; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 95000; } }
        public override int SellPrice { get { return 47500; } }

        public override spells.Spell SpellTaught { get { return new spells.Medusa(); } }

        public MedusaBook() : base(3)
        {
        }

        public MedusaBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
            
            public class RecallBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF RECALL"; } }
        public override int MenReq { get { return 495; } }
        public override int MenReqPl { get { return 25; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 150000; } }
        public override int SellPrice { get { return 75000; } }

        public override spells.Spell SpellTaught { get { return new spells.Recall(); } }

        public RecallBook() : base(3)
        {
        }

        public RecallBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class WildMonkBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF WILD MONK"; } }
        public override int MenReq { get { return 518; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 110000; } }
        public override int SellPrice { get { return 55000; } }

        public override spells.Spell SpellTaught { get { return new spells.WildMonk(); } }

        public WildMonkBook() : base(3)
        {
        }

        public WildMonkBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
                public class DragonOfFireBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF DRAGON OF FIRE"; } }
        public override int MenReq { get { return 686; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 195; } }
        public override int DexReqPl { get { return 4; } }
        public override int LevelReq { get { return 0; } }
        public override int LevelReqPl { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 120000; } }
        public override int SellPrice { get { return 60000; } }

        public override spells.Spell SpellTaught { get { return new spells.DragonOfFire(); } }

        public DragonOfFireBook() : base(3)
        {
        }

        public DragonOfFireBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }
    
            public class CurveShockBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF CURVE SHOCK"; } }
        public override int MenReq { get { return 1000; } }
        public override int MenReqPl { get { return 300; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 135; } }
        public override int LevelReqPl { get { return 5; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int SellPrice { get { return 1000000; } }//changed sell price to 1m

        public override spells.Spell SpellTaught { get { return new spells.CurveShock(); } }

        public CurveShockBook()
            : base(3)
        {
        }

        public CurveShockBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class TwisterBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TWISTER"; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 00; } }
        public override int StrReq { get { return 300; } }
        public override int StrReqPl { get { return 15; } }//added str pl 15
        public override int DexReq { get { return 75; } }//added dex req 75
        public override int DexReqPl { get { return 10; } }//added dex pl 10
        public override int LevelReq { get { return 75; } }//changed level req to 75
        public override int LevelReqPl { get { return 5; } }
        
        public override int SellPrice { get { return 10000; } }//changed sell price to 10,000

        public override spells.Spell SpellTaught { get { return new spells.Twister(); } }
        public override Class ClassReq { get { return Class.Knight; } }
        public TwisterBook()
            : base(3)
        {
        }

        public TwisterBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class TripleBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TRIPLE"; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 00; } }
        public override int DexReq { get { return 300; } }
        public override int DexReqPl { get { return 15; } }
        public override int StrReq { get { return 75; } }//added Str req 75
        public override int StrReqPl { get { return 10; } }//added Str pl 10
        public override int LevelReq { get { return 75; } }//changed level req to 75
        public override int LevelReqPl { get { return 5; } }

        public override int SellPrice { get { return 10000; } }//changed sell price to 10.000

        public override spells.Spell SpellTaught { get { return new spells.Triple(); } }
        public override Class ClassReq { get { return Class.Swordsman; } }
        public TripleBook()
            : base(3)
        {
        }

        public TripleBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class TeleportBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TELEPORT"; } }
        public override int MenReq { get { return 60; } }
        public override int MenReqPl { get { return 16; } }
        public override int DexReq { get { return 92; } }
        public override int DexReqPl { get { return 4; } }
        public override int LevelReq { get { return 0; } }

        public override int BuyPrice { get { return 25000; } }
        public override int SellPrice { get { return 12500; } }//sells for 12.500

        public override spells.Spell SpellTaught { get { return new spells.Teleport(); } }

        public TeleportBook()
            : base(3)
        {
        }

        public TeleportBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class SidewinderBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF SIDEWINDER"; } }
        public override int MenReq { get { return 105; } }
        public override int MenReqPl { get { return 15; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Swordsman | Class.Shaman; } }

        public override int BuyPrice { get { return 30000; } }
        public override int SellPrice { get { return 15000; } }//sells for 5,000

        public override spells.Spell SpellTaught { get { return new spells.Sidewinder(); } }

        public SidewinderBook()
            : base(3)
        {
        }

        public SidewinderBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class AssassinSpecialBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ASSASSIN SPECIAL"; } }
        public override int MenReq { get { return 800; } }//updated to 800 req
        public override int MenReqPl { get { return 50; } }// updated to 50 more per lvl
        public override int DexReq { get { return 200; } }//updated to 200 dex req
        public override int DexReqPl { get { return 25; } }//updated to 25 dex per lvl
        public override int LevelReq { get { return 115; } }//updated to 115 level req
        public override int LevelReqPl { get { return 5; } }//updated to 5 level pl
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int SellPrice { get { return 100000; } }//sell price 100,000

        public override spells.Spell SpellTaught { get { return new spells.AssassinSpecial(); } }

        public AssassinSpecialBook()
            : base(3)
        {
        }

        public AssassinSpecialBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class FireBallBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE BALL"; } }
        public override int MenReq { get { return 28; } }
        public override int MenReqPl { get { return 7; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }

        public override int BuyPrice { get { return 1000; } }
        public override int SellPrice { get { return 500; } }//sells for 500

        public override spells.Spell SpellTaught { get { return new spells.FireBall(); } }

        public FireBallBook()
            : base(3)
        {
        }

         public FireBallBook(Serial serial) : base(serial)
        {
        }
    }

    public class FlameRoundBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FLAME ROUND"; } }
        public override int MenReq { get { return 38; } }
        public override int MenReqPl { get { return 9; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }

        public override int SellPrice { get { return 5000; } }//sells for 5,000
        
        public override spells.Spell SpellTaught { get { return new spells.FlameRound(); } }

        public FlameRoundBook()
            : base(3)
        {
        }

        public FlameRoundBook(Serial serial) : base(serial)
        {
        }
    }

    public class ThunderCrossBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF THUNDER CROSS"; } }
        public override int MenReq { get { return 53; } }
        public override int MenReqPl { get { return 13; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        
        public override int SellPrice { get { return 7500; } }//sells for 7.500

        public override spells.Spell SpellTaught { get { return new spells.ThunderCross(); } }

        public ThunderCrossBook()
            : base(3)
        {
        }

        public ThunderCrossBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class GrandBigBangBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF GRAND BIG BANG"; } }
        public override int MenReq { get { return 800; } }//updated to 800 req
        public override int MenReqPl { get { return 50; } }// updated to 50 more per lvl
        public override int DexReq { get { return 200; } }//updated to 200 dex req
        public override int DexReqPl { get { return 25; } }//updated to 25 dex per lvl
        public override int LevelReq { get { return 115; } }//updated to 115 level req
        public override int LevelReqPl { get { return 5; } }//updated to 5 level pl

        public override int SellPrice { get { return 100000; } }//sells for 100,000

        public override spells.Spell SpellTaught { get { return new spells.GrandBigBang(); } }
        public override Class ClassReq { get { return Class.Wizard; } }
        public GrandBigBangBook()
            : base(3)
        {
        }

        public GrandBigBangBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class BigBangBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF BIG BANG"; } }
        public override int MenReq { get { return 245; } }
        public override int MenReqPl { get { return 15; } }
        public override int DexReq { get { return 100; } }
        public override int DexReqPl { get { return 5; } }
        public override int LevelReq { get { return 50; } }
        public override int LevelReqPl { get { return 2; } }
        
        public override int SellPrice { get { return 50000; } }

        public override spells.Spell SpellTaught { get { return new spells.BigBang(); } }
        public override Class ClassReq { get { return Class.Wizard; } }
        public BigBangBook()
            : base(3)
        {
        }

        public BigBangBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class UltraBigBangBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ULTRA BIG BANG"; } }
        public override int MenReq { get { return 480; } }
        public override int MenReqPl { get { return 20; } }
        public override int DexReq { get { return 195; } }
        public override int DexReqPl { get { return 5; } }
        public override int LevelReq { get { return 80; } }
        public override int LevelReqPl { get { return 2; } }
        
        
        public override int SellPrice { get { return 75000; } }

        public override spells.Spell SpellTaught { get { return new spells.UltraBigBang(); } }
        public override Class ClassReq { get { return Class.Wizard; } }
        public UltraBigBangBook()
            : base(3)
        {
        }

        public UltraBigBangBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class AssassinBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ASSASSIN"; } }
        public override int MenReq { get { return 435; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 234; } }
        public override int DexReqPl { get { return 7; } }
        public override int LevelReq { get { return 0; } }
        
        public override int SellPrice { get { return 75000; } }

        public override spells.Spell SpellTaught { get { return new spells.Assassin(); } }
        public override Class ClassReq { get { return Class.Shaman; } }
        public AssassinBook()
            : base(3)
        {
        }

        public AssassinBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class TraceBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TRACE"; } }
        public override int MenReq { get { return 38; } }
        public override int MenReqPl { get { return 10; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }

        public override int BuyPrice { get { return 4000; } }
        public override int SellPrice { get { return 15000; } }

        public override spells.Spell SpellTaught { get { return new spells.Trace(); } }

        public TraceBook()
            : base(3)
        {
        }

        public TraceBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class RevelationBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF REVELATION"; } }
        public override int MenReq { get { return 475; } }
        public override int MenReqPl { get { return 9; } }
        public override int DexReq { get { return 268; } }
        public override int DexReqPl { get { return 6; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman;}}
        public override int BuyPrice { get { return 4000; } }
        public override int SellPrice { get { return 25000; } }

        public override spells.Spell SpellTaught { get { return new spells.Revelation(); } }

        public RevelationBook()
            : base(3)
        {
        }

        public RevelationBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class MagmaHandBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MAGMA HAND"; } }
        public override int MenReq { get { return 475; } }
        public override int MenReqPl { get { return 9; } }
        public override int DexReq { get { return 268; } }
        public override int DexReqPl { get { return 6; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 4000; } }
        public override int SellPrice { get { return 50000; } }

        public override spells.Spell SpellTaught { get { return new spells.MagmaHand(); } }

        public MagmaHandBook()
            : base(3)
        {
        }

        public MagmaHandBook(Serial serial)
            : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class HealBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF HEAL"; } }
        public override int MenReq { get { return 22; } }
        public override int MenReqPl { get { return 4; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }

        public override int BuyPrice { get { return 4000; } }
        public override int SellPrice { get { return 2000; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.Heal(); } }

        public HealBook()
            : base(3)
        {
        }

         public HealBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class PlusHealBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF PLUS HEAL"; } }
        public override int MenReq { get { return 200; } }
        public override int MenReqPl { get { return 5; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman | Class.Wizard; } }

        public override int BuyPrice { get { return 5000; } }
        public override int SellPrice { get { return 2500; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.PlusHeal(); } }

        public PlusHealBook()
            : base(3)
        {
        }

         public PlusHealBook(Serial serial) : base(serial)
        {
            m_ItemID = 3;
        }
    }

    public class MagicArmorBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MAGIC ARMOR"; } }
        public override int MenReq { get { return 24; } }
        public override int MenReqPl { get { return 4; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Knight; } }

        public override int BuyPrice { get { return 5000; } }
        public override int SellPrice { get { return 2500; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.MagicArmor(); } }

        public MagicArmorBook()
            : base(3)
        {
        }

         public MagicArmorBook(Serial serial) : base(serial)
        {
        }
    }

    public class MentalSwordBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MENTAL SWORD"; } }
        public override int MenReq { get { return 30; } }
        public override int MenReqPl { get { return 5; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 31; } }
        public override Class ClassReq { get { return Class.Knight; } }

        public override int BuyPrice { get { return 15000; } }
        public override int SellPrice { get { return 7500; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.MentalSword(); } }

        public MentalSwordBook()
            : base(3)
        {
        }

        public MentalSwordBook(Serial serial) : base(serial)
        {
        }
    }

    public class RainbowArmorBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF RAINBOW ARMOR"; } }
        public override int MenReq { get { return 312; } }
        public override int MenReqPl { get { return 24; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 25000; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.RainbowArmor(); } }

        public RainbowArmorBook() 
            : base(3)
        {
        }

         public RainbowArmorBook(Serial serial) : base(serial)
        {
        }
    }

    public class GuardianSwordBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF GUARDIAN SWORD"; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 0; } }
        public override int DexReq { get { return 98; } }
        public override int DexReqPl { get { return 8; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Swordsman; } }

        public override int BuyPrice { get { return 5000; } }
        public override int SellPrice { get { return 2500; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.GuardianSword(); } }

        public GuardianSwordBook()
            : base(3)
        {
        }

        public GuardianSwordBook(Serial serial) : base(serial)
        {
        }
    }

    public class FireProtectorBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE PROTECTOR"; } }
        public override int MenReq { get { return 162; } }
        public override int MenReqPl { get { return 14; } }
        public override int DexReq { get { return 65; } }
        public override int DexReqPl { get { return 8; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 10000; } }
        public override int SellPrice { get { return 5000; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.FireProtector(); } }

        public FireProtectorBook()
            : base(3)
        {
        }

        public FireProtectorBook(Serial serial) : base(serial)
        {
        }
    }

    public class TeagueShieldBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF TEAGUE SHIELD"; } }
        public override int MenReq { get { return 112; } }
        public override int MenReqPl { get { return 9; } }
        public override int DexReq { get { return 45; } }
        public override int DexReqPl { get { return 5; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Shaman; } }

        public override int BuyPrice { get { return 10000; } }
        public override int SellPrice { get { return 5000; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.TeagueShield(); } }

        public TeagueShieldBook()
            : base(3)
        {
        }

        public TeagueShieldBook(Serial serial) : base(serial)
        {
        }
    }

    public class MagicShieldBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF MAGIC SHIELD"; } }
        public override int MenReq { get { return 140; } }
        public override int MenReqPl { get { return 14; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int BuyPrice { get { return 10000; } }
        public override int SellPrice { get { return 5000; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.MagicShield(); } }

        public MagicShieldBook()
            : base(3)
        {
        }

        public MagicShieldBook(Serial serial) : base(serial)
        {
        }
    }

    public class ZigZagBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF ZIG ZAG"; } }
        public override int MenReq { get { return 17; } }
        public override int MenReqPl { get { return 3; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int BuyPrice { get { return 800; } }
        public override int SellPrice { get { return 400; } }//updated to reflect sale to loen -50% gold spent

        public override spells.Spell SpellTaught { get { return new spells.ZigZag(); } }

        public ZigZagBook()
            : base(3)
        {
        }

         public ZigZagBook(Serial serial) : base(serial)
        {
        }
    }

    public class FireHawkBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE HAWK"; } }
        public override int MenReq { get { return 590; } }
        public override int MenReqPl { get { return 11; } }
        public override int DexReq { get { return 172; } }
        public override int DexReqPl { get { return 3; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Wizard; } }

        public override int SellPrice { get { return 20000; } }
        
        public override spells.Spell SpellTaught { get { return new spells.FireHawk(); } }

        public FireHawkBook()
            : base(3)
        {
        }

        public FireHawkBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class FireWallBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE WALL"; } }
        public override int MenReq { get { return 50; } }
        public override int MenReqPl { get { return 12; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 3; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }

        public override int SellPrice { get { return 10000; } }

        public override spells.Spell SpellTaught { get { return new spells.FireWall(); } }

        public FireWallBook()
            : base(3)
        {
        }

        public FireWallBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class FireShotBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FIRE SHOT"; } }
        public override int MenReq { get { return 98; } }
        public override int MenReqPl { get { return 26; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return 0; } }
        
        public override int SellPrice { get { return 15000; } }//updated sell price to 15,000

        public override spells.Spell SpellTaught { get { return new spells.FireShot(); } }

        public FireShotBook()
            : base(3)
        {
        }

        public FireShotBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class DeadlyBoomBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF DEADLY BOOM"; } }
        public override int MenReq { get { return 533; } }
        public override int MenReqPl { get { return 13; } }
        public override int DexReq { get { return 0; } }
        public override int DexReqPl { get { return 0; } }
        public override int LevelReq { get { return 0; } }
        
        public override int SellPrice { get { return 25000; } }
                
        public override Class ClassReq { get { return Class.Wizard; } }

        public override spells.Spell SpellTaught { get { return new spells.DeadlyBoom(); } }

        public DeadlyBoomBook()
            : base(3)
        {
        }

        public DeadlyBoomBook(Serial serial)
            : base(serial)
        {
        }
    }

    public class DemonDeathBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF DEMON DEATH"; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 0; } }
        public override int DexReq { get { return 260; } }//updated dex req to 260
        public override int DexReqPl { get { return 12; } }
        public override int LevelReq { get { return 50; } }
        public override int LevelReqPl { get { return 5; } }
        public override Class ClassReq { get { return Class.Swordsman; } }

        public override int BuyPrice { get { return 50000; } }
        public override int SellPrice { get { return 5000; } }

        public override spells.Spell SpellTaught { get { return new spells.DemonDeath(); } }

        public DemonDeathBook()
            : base(3)
        {
        }

        public DemonDeathBook(Serial serial) : base(serial)
        {
        }
    }

    public class ExecutionBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF EXECUTION"; } }
        public override int MenReq { get { return 0; } }
        public override int MenReqPl { get { return 0; } }
        public override int DexReq { get { return 125; } }//updated to 125dex req
        public override int DexReqPl { get { return 5; } }//updated to 5 pl dex req
        public override int LevelReq { get { return 25; } }//updated to require level 25
        public override int LevelReqPl { get { return 5; } }//updated to require 5 levels per book
        public override Class ClassReq { get { return Class.Swordsman; } }

        public override int BuyPrice { get { return 0; } }
        public override int SellPrice { get { return 500; } }

        public override spells.Spell SpellTaught { get { return new spells.Execution(); } }

        public ExecutionBook()
            : base(3)
        {
        }

        public ExecutionBook(Serial serial) : base(serial)
        {
        }
    }

    public class FlyingSwordBook : BaseSpellbook
    {
        public override string Name { get { return "BOOK OF FLYING SWORD"; } }
        public override int MenReq { get { return 130; } }
        public override int MenReqPl { get { return 5; } }
        public override int DexReq { get { return 360; } }
        public override int DexReqPl { get { return 5; } }
        public override int LevelReq { get { return 0; } }
        public override Class ClassReq { get { return Class.Swordsman; } }

        public override int BuyPrice { get { return 0; } }
        public override int SellPrice { get { return 25000; } }//set sell to 25,000

        public override spells.Spell SpellTaught { get { return new spells.FlyingSword(); } }

        public FlyingSwordBook()
            : base(3)
        {
        }

        public FlyingSwordBook(Serial serial) : base(serial)
        {
        }
    }
}

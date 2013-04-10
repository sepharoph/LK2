namespace LKCamelot.script.spells
{
    public class StartingPoint : Spell
    {
        public override string Name { get { return "STARTING POINT"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/* Spell Returns Character to the enterance of the Map or Dungeon

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -35 Mana 
(Max level 99-12 -15 Mana) Per Cast*/


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 35; } }//fixed mana cost
        public override int ManaCostPl { get { return 0; } }
        public override int Range
        {
            get
            {
                return 9;
            }
        }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    65,  //impact
                    0,  //thickness
                    3,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public StartingPoint()
        {
        }
    }
}

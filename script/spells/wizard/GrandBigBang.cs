namespace LKCamelot.script.spells
{
    public class GrandBigBang : Spell
    {
        public override string Name { get { return "GRAND BIG BANG"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -6% Mana 
(Max level 99-12 -4% Mana) Per Cast, Damage would Start (w/ 12 Books) 
744 damage + menCoff, (Max level 99-12 (744 damage + menCoff) + 9%)
This spell could be casted on all Enemy Players/Monster's. */

        public override int DamBase { get { return 612 } }//compared to assassin special closed gap
        public override int DamPl { get { return 12; } }//compared to assassin special closed gap
        public override int ManaCost { get { return -77; } }
        public override int ManaCostPl { get { return 6; } }
        public override int menCoff { get { return 6; } }
        public override int Range
        {
            get
            {
                return 5;
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
                    66,  //impact
                    0,  //thickness
                    3,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public GrandBigBang()
        {
        }
    }
}

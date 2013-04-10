namespace LKCamelot.script.spells
{
    public class SmogScreen : Spell
    {
        public override string Name { get { return "SMOG SCREEN"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -25% Mana 
(Max level 99:12 -20% Mana) Per Cast, Damage would Start (w/ 12 Books) 
30 damage + menCoff, (Max level 99-12 (30 damage + menCoff) + 9%)
This spell could be casted on all Enemy Players/Monster's. */


        public override int DamBase { get { return 8; } }
        public override int DamPl { get { return 2; } }
        public override int ManaCost { get { return -58; } }
        public override int ManaCostPl { get { return 3; } }
        public override int menCoff { get { return 9; } }
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

        public SmogScreen()
        {
        }
    }
}

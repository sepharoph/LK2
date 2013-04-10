namespace LKCamelot.script.spells
{
    public class Lightning : Spell
    {
        public override string Name { get { return "LIGHTNING"; } } 
        public override int SpellLearnedIcon { get { return 72; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Shoots a Line of Electric at a target, the line is 3 squares long and 1 square thick.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -106 Mana 
(Max level 99:12 -56 Mana) Per Cast, Damage would Start (w/ 12 Books) 
132 damage, (Max level 99:12 (132 damage + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 66; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return 40; } }
        public override int ManaCostPl { get { return 6; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    44,  //impact
                    0,  //thickness
                    0,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public Lightning()
        {
        }
    }
}

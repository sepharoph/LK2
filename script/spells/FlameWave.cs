namespace LKCamelot.script.spells
{
    public class FlameWave : Spell
    {
        public override string Name { get { return "FLAME WAVE"; } } 
        public override int SpellLearnedIcon { get { return 16; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*This effect expands from the caster in a Cross Shape AOE
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -98 Mana 
(Max level 99-12 -36) Per Cast, Damage would Start (w/ 12 Books) 
164 damage, (Max level 99-12 (164 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 58; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return 38; } }
        public override int ManaCostPl { get { return 6; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    40,  //oncast
                    52,  //moving
                    0,  //impact
                    2,  //thickness
                    0,  //type
                    6,  //speed
                    2  //streak
                    );
            }
        }

        public FlameWave()
        {
        }
    }
}

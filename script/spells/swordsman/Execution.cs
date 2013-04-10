﻿namespace LKCamelot.script.spells
{
    public class Execution : Spell
    {
        public override string Name { get { return "EXECUTION"; } }
        public override int SpellLearnedIcon { get { return 51; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -12% Mana 
(Max level 99-12 -8%) Per Cast, Damage would Start (w/ 12 Books) 
510 damage + dexCoff, (Max level 99-12 (510damage + dexCoff) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 390; } }
        public override int DamPl { get { return 12; } }
        public override int ManaCost { get { return -67; } }
        public override int ManaCostPl { get { return 5; } }
        public override int dexCoff { get { return 8; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Swordsman; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    69,  //oncast
                    69,  //moving
                    68,  //impact
                    0,  //thickness
                    0,  //type
                    16,  //speed
                    10  //streak
                    );
            }
        }

        public Execution()
        {
        }
    }
}

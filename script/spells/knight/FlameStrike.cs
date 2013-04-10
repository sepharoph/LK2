﻿namespace LKCamelot.script.spells
{
    public class FlameStrike : Spell
    {
        public override string Name { get { return "FLAME STRIKE"; } }
        public override int SpellLearnedIcon { get { return 67; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -34% Mana 
(Max level 99-12 -30% Mana) Per Cast, Damage would Start (w/ 12 Books) 
2550 damage + strCoff, (Max level 99-12 (2550damage + menCoff) + 9%)
This spell could be casted on all enemy's. */

        public override int DamBase { get { return 2000; } }//updated
        public override int DamPl { get { return 50; } }//updated
        public override int ManaCost { get { return -100; } }//updated
        public override int ManaCostPl { get { return 6; } }//updated
        public override int RecastTime { get { return 2000; } }//updated
        public override int strCoff { get { return 2; } }//attempted this line
        public override int Range { get { return 1; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Knight; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0,  //impact
                    0,  //thickness
                    0,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public FlameStrike()
        {
        }
    }
}

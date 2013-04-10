﻿namespace LKCamelot.script.spells
{
    public class CurveShock : Spell
    {
        public override string Name { get { return "CURVE SHOCK"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) +20% Mana 
(Max level 99-12 +23% Mana) Per Cast, Damage would Start (w/ 12 Books) 
1950 damage + menCoff, (Max level 99-12 (1950damage + menCoff) + 9%)
This spell could be casted on all enemy's. */

        public override int DamBase { get { return 1400; } }
        public override int DamPl { get { return 50; } }
        public override int ManaCost { get { return -100; } }
        public override int ManaCostPl { get { return 10; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override int RecastTime { get { return 2000; } }
        public override int menCoff { get { return 2; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    111,  //oncast
                    112,  //moving
                    113,  //impact
                    0,  //thickness
                    2,  //type
                    16,  //speed
                    0  //streak
                    );
            }
        }

        public CurveShock()
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class ZigZag : Spell
    {
        public override string Name { get { return "ZIG ZAG"; } }
        public override int SpellLearnedIcon { get { return 21; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*shoots ZigZagging Electric that flies through the air.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -16 Mana 
(Max level 99:12 -4) Per Cast, Damage would Start (w/ 12 Books) 
66 damage, (Max level 99:12 (66 Damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 22; } }
        public override int DamPl { get { return 4; } }
        public override int ManaCost { get { return 16; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,   //oncast
                    81,  //moving
                    0,   //impact
                    0,   //thickness
                    0,   //type
                    7,   //speed
                    0    //streak
                    );
            }
        }

        public ZigZag()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class Sidewinder : Spell
    {
        public override string Name { get { return "SIDEWINDER"; } }
        public override int SpellLearnedIcon { get { return 13; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Shoots an attack in the shape of a spiral snake at the target.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -24% Mana 
(Max level 99-12 -20%) Per Cast, Damage would Start (w/ 12 Books) 
410 damage + dexCoff, (Max level 99-12 (410 damage + dexCoff) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 300; } }
        public override int DamPl { get { return 10; } }
        public override int ManaCost { get { return -68; } }
        public override int ManaCostPl { get { return 4; } }
        public override int dexCoff { get { return 8; } }
        public override library.Class ClassReq { get { return library.Class.Swordsman | library.Class.Shaman; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    22,   //oncast
                    37,  //moving
                    0,   //impact
                    0,   //thickness
                    0,   //type
                    9,   //speed
                    0    //streak
                    );
            }
        }

        public Sidewinder()
        {
        }
    }
}

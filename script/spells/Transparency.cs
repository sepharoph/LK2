using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class Transparency : Spell
    {
        public override string Name { get { return "TRANSPARENCY"; } }
        public override int SpellLearnedIcon { get { return 13; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Makes Character visible only to Magic spells, and Animals.
Level of spell decreased mana cost, Starting at (w/ 12Books) -55% Mana 
(Max level 99:12 -30%) Per Cast.
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -55; } }
        public override int ManaCostPl { get { return 0; } }
        public override library.Class ClassReq { get { return library.Class.Swordman | library.Class.Wizard; } }

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

        public Transparency()
        {
        }
    }
}

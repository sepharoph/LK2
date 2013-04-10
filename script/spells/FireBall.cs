using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class FireBall : Spell
    {
        public override string Name { get { return "FIRE BALL"; } }
        public override int SpellLearnedIcon { get { return 12; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Shoots Fireball at Target
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -32 Mana 
(Max level 99-12 -16) Per Cast, Damage would Start (w/ 12 Books) 
112 damage, (Max level 99-12 (112 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 46; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return 32; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    00,   //oncast
                    23,  //moving
                    00,   //impact
                    0,   //thickness
                    0,   //type
                    9,   //speed
                    0    //streak
                    );
            }
        }

        public FireBall()
        {
        }
    }
}

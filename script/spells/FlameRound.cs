using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class FlameRound : Spell
    {
        public override string Name { get { return "FLAME ROUND"; } }
        public override int SpellLearnedIcon { get { return 18; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* Shoots a circle of fire from the player.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -54 Mana 
(Max level 99:12 -32 Mana Per Cast) Per Cast, Damage would Start (w/ 12 Books) 
136 damage, (Max level 99:12 (136 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 70; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return 54; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,   //oncast
                    25,  //moving
                    15,   //impact
                    0,   //thickness
                    1,   //type
                    6,   //speed
                    0    //streak
                    );
            }
        }

        public FlameRound()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class ThunderCross : Spell
    {
        public override string Name { get { return "THUNDER CROSS"; } }
        public override int SpellLearnedIcon { get { return 24; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* This Spell is supposed to fire lightning in the shape of a cross from the player.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -105 Mana 
(Max level 99-12 -55 Mana Per Cast) Per Cast, Damage would Start (w/ 12 Books) 
210, (Max level 99-12 (210 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's using @pk feature for players. */

        public override int DamBase { get { return 132; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return 105; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,   //oncast
                    32,  //moving
                    0,   //impact
                    0,   //thickness
                    1,   //type
                    6,   //speed
                    0    //streak
                    );
            }
        }

        public ThunderCross()
        {
        }
    }
}

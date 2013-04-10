using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class HonestBolt : Spell
    {
        public override string Name { get { return "HONEST BOLT"; } }
        public override int SpellLearnedIcon { get { return 24; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* This Spell is supposed to shoot a bolt lightning from the player.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -16% Mana 
(Max level 99:12 -12%) Per Cast, Damage would Start (w/ 12 Books) 
688 damage, (Max level 99:12 (688 damage) + 9%)
This spell could be casted on Only Undead,Demons, and Animals. */

        public override int DamBase { get { return 567; } }
        public override int DamPl { get { return 11; } }
        public override int ManaCost { get { return 60; } }
        public override int ManaCostPl { get { return 4; } }

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

        public HonestBolt()
        {
        }
    }
}

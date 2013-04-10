using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class MoonLight : Spell
    {
        public override string Name { get { return "MOON LIGHT"; } }
        public override int SpellLearnedIcon { get { return 21; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*This effect only hits Undead Monsters & Animals w/ a beam of light
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -80 Mana 
(Max level 99:12 -20) Per Cast, Damage would Start (w/ 12 Books) 
114 damage, (Max level 99:12 (114 Damage) + 9%) */

        public override int DamBase { get { return 48; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return 25; } }
        public override int ManaCostPl { get { return 5; } }

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

        public MoonLight()
        {
        }
    }
}

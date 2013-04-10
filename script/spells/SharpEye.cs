using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class SharpEye : Spell
    {
        public override string Name { get { return "SHARP EYE"; } }
        public override int SpellLearnedIcon { get { return 13; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Magic level 1~4: detect 
fire land mines and 
electric land mines 
Magic level 5~8: detect 
fire pillar and electric 
pillar 
Magic level 9~12: 
detects magic land 
mines and thorn bombs */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -45; } }
        public override int ManaCostPl { get { return 0; } }
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

        public SharpEye()
        {
        }
    }
}

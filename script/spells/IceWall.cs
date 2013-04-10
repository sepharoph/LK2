using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class IceWall : Spell
    {
        public override string Name { get { return "ICE WALL"; } }
        public override int SpellLearnedIcon { get { return 13; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Forms a wall of Ice around target only penetrable by physical attack and is impervious to magic.
+50 AC(+10AC per book) 12 Books = 160AC
Level of spell decreased mana cost and increase AC, Starting at (w/ 12Books) -120 Mana 
(Max level 99-12 -80) Per Cast, Damage would Start (w/ 12 Books) 
270 damage, (Max level 99-12 (160 AC) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 182; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return -55; } }
        public override int ManaCostPl { get { return 3; } }
        public override library.Class ClassReq { get { return library.Class.Shaman | library.Class.Wizard; } }

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

        public IceWall()
        {
        }
    }
}

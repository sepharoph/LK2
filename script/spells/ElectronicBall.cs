using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class ElectronicBall : Spell
    {
        public override string Name { get { return "ELECTRONIC BALL"; } }
        public override int SpellLearnedIcon { get { return 58; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }
/* Launches an Electric Ball
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -25 Mana 
(Max level 99-12 -10) Per Cast, Damage would Start (w/ 12 Books) 
90 damage, (Max level 99-12 (709 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 35; } }
        public override int DamPl { get { return 5; } }
        public override int ManaCost { get { return 25; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,
                    81,
                    0,
                    0,
                    0,
                    9,
                    0
                    );
            }
        }

        public ElectronicBall()
        {
        }
    }
}

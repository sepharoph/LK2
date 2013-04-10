using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class TwinCobra : Spell
    {
        public override string Name { get { return "TWIN COBRA"; } }
        public override int SpellLearnedIcon { get { return 13; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Summons a two headed snake that shoots fire ball and electric ball.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -22% Mana 
(Max level 99-12 -18%) Per Cast, Damage would Start (w/ 12 Books) 
270 damage, (Max level 99-12 (270 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 182; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return -55; } }
        public override int ManaCostPl { get { return 3; } }
        public override library.Class ClassReq { get { return library.Class.Knight | library.Class.Wizard; } }

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

        public TwinCobra()
        {
        }
    }
}

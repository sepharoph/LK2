using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class Triple : Spell
    {
        public override string Name { get { return "TRIPLE"; } }
        public override int SpellLearnedIcon { get { return 74; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

        /*Allows player to attack 3 squares at once, more books = more damage to square 2,3.
        Level of spell decreased mana cost and increases attack speed, Starting at (w/ 12Books) -50 Mana 
        (Max level 99:12 -0 Mana) Per Cast, Attack Speed -0 1:12 (Max level 99:12 -99 Attack Speed)
         This spell would allow players to hit enemy's in correct squares. */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -50; } }
        public override int ManaCostPl { get { return 0; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Swordsman; } }

        public override Buff BuffEffect
        {
            get
            {
                var tbuff = new Buff();
                tbuff.BuffType = BuffCase.Triple;
                return tbuff;
            }
        }

        public override bool Cast(LKCamelot.model.Player player)
        {
            CheckLevelUp(player);
            player.AddBuff(this);
            return true;
        }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,   //oncast
                    0,  //moving
                    0,   //impact
                    0,   //thickness
                    3,   //type
                    3,   //speed
                    0    //streak
                    );
            }
        }

        public Triple()
        {
        }
    }
}

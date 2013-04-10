using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class MagicArmor : Spell
    {
        public override string Name { get { return "MAGIC ARMOR"; } }
        public override int SpellLearnedIcon { get { return 35; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/*Level of spell reduced mana cost and increased duration, Starting at 20minutes.
(Max 30 Minutes 99:12) for buff, mana cost would start at -20% (-10% Mana at Max Lvl 99:12).
This spell could be casted only on self. Also message was displayed to the player 
when counting down to remove effect
    30seconds than 10,5-1 then says Magic Shield Removed (Sold at Employee)*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -20; } }
        public override int ManaCostPl { get { return 0; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Knight; } }
        public override Buff BuffEffect
        {
            get
            {
                var tbuff = new Buff();
                tbuff.fAC = 0.16f;
                tbuff.fACpl = 0.01f;
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
                    57,   //oncast
                    0,  //moving
                    0,   //impact
                    0,   //thickness
                    0,   //type
                    1,   //speed
                    0    //streak
                    );
            }
        }

        public MagicArmor()
        {
        }
    }
}

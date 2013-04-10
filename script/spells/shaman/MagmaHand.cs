﻿namespace LKCamelot.script.spells
{
    public class MagmaHand : Spell
    {
        public override string Name { get { return "MAGMA HAND"; } }
        public override int SpellLearnedIcon { get { return 70; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -8% Mana 
(Max level 99-12 -4%) Per Cast, Damage would Start (w/ 12 Books) 
954 damage + menCoff, (Max level 99-12 (954damage + menCoff) + 9%)
This spell could be casted on all enemy's. */

        public override int DamBase { get { return 778; } }//supposed to do 2nd most single target damage
        public override int DamPl { get { return 16; } }
        public override int ManaCost { get { return -96; } }//compared with other spells
        public override int ManaCostPl { get { return 8; } }//compared with other spells
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Shaman; } }
        public override int menCoff { get { return 5; } }//strong spell
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    7,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public MagmaHand()
        {
        }
    }
}

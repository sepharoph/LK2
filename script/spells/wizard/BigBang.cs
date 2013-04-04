﻿namespace LKCamelot.script.spells
{
    public class BigBang : Spell
    {
        public override string Name { get { return "BIG BANG"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

        public override int DamBase { get { return 488; } }
        public override int DamPl { get { return 12; } }
        public override int ManaCost { get { return -77; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    64,  //impact
                    0,  //thickness
                    0,  //type
                    30,  //speed
                    0  //streak
                    );
            }
        }

        public BigBang()
        {
        }
    }
}
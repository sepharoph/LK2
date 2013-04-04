﻿namespace LKCamelot.script.spells
{
    public class FrameStrike : Spell
    {
        public override string Name { get { return "FRAME STRIKE"; } }
        public override int SpellLearnedIcon { get { return 67; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

        public override int DamBase { get { return 152; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return 102; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Knight; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0,  //impact
                    0,  //thickness
                    0,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public FrameStrike()
        {
        }
    }
}
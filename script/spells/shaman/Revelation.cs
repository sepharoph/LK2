namespace LKCamelot.script.spells
{
    public class Revelation : Spell
    {
        public override string Name { get { return "REVELATION"; } }
        public override int SpellLearnedIcon { get { return 65; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

        public override int DamBase { get { return 655; } }// compared to firehawk
        public override int DamPl { get { return 15; } }//compared to firehawk
        public override int ManaCost { get { return -80; } }//compared to firehawk
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Shaman; } }
        public override int menCoff { get { return 8; } }//compared to other class specific spells
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    21,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public Revelation()
        {
        }
    }
}

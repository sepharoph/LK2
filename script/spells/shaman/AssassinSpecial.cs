namespace LKCamelot.script.spells
{
    public class AssassinSpecial : Spell
    {
        public override string Name { get { return "ASSASSIN SPECIAL"; } }
        public override int SpellLearnedIcon { get { return 23; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

        public override int DamBase { get { return 636; } }//compared to other spells
        public override int DamPl { get { return 14; } }
        public override int ManaCost { get { return -78; } }//compared to other spells
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Shaman; } }
        public override int menCoff { get { return 7; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    75,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public AssassinSpecial()
        {
        }
    }
}

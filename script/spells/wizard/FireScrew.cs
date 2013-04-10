namespace LKCamelot.script.spells
{
    public class FireScrew : Spell
    {
        public override string Name { get { return "FIRE SCREW"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Attacks in the shape of a twisted spiral on the ground, similar to sidewinder maybe? */

        public override int DamBase { get { return 270; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return -42; } }
        public override int ManaCostPl { get { return 8; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard;
        public override int menCoff { get { return 9; } }
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

        public FireScrew()
        {
        }
    }
}

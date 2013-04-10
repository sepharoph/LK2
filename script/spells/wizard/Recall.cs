namespace LKCamelot.script.spells
{
    public class Recall : Spell
    {
        public override string Name { get { return "RECALL"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Pulls A Player or Monster next to the caster (1 Square/Cell per book max 12 squares) */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -65; } }//%based mana usage
        public override int ManaCostPl { get { return 3; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
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

        public Recall()
        {
        }
    }
}

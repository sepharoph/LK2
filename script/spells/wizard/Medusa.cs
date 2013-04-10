namespace LKCamelot.script.spells
{
    public class Medusa : Spell
    {
        public override string Name { get { return "MEDUSA"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Summons a Medusa, Looks like Monster, Is Demon, Has 0 DMG , 
Taunts All Mobs on Caster to Attack Medusa 70AC (+10 per Book) */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -76; } }
        public override int ManaCostPl { get { return 4; } }
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

        public Medusa()
        {
        }
    }
}

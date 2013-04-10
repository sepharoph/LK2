namespace LKCamelot.script.spells
{
    public class Opening : Spell
    {
        public override string Name { get { return "OPENING"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/* Spell opens doors that may be sealed

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -5% Mana 
(Max level 99:12 -0 Mana) Per Cast */


        public override int DamBase { get { return 666; } }
        public override int DamPl { get { return 20; } }
        public override int ManaCost { get { return -5; } }
        public override int ManaCostPl { get { return 0; } }
        public override int menCoff { get { return 9; } }
        public override int Range
        {
            get
            {
                return 9;
            }
        }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    65,  //impact
                    0,  //thickness
                    3,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public Opening()
        {
        }
    }
}

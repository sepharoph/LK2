namespace LKCamelot.script.spells
{
    public class X-Ray : Spell
    {
        public override string Name { get { return "X-RAY"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/* Spell sees through walls for other characters and monsters on he other side

/*Level of spell decreased mana cost, Starting at (w/ 12Books) -90 Mana 
(Max level 99:12 -45 Mana) Per Cast */


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 90; } }
        public override int ManaCostPl { get { return ; } }
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

        public X-Ray()
        {
        }
    }
}

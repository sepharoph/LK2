namespace LKCamelot.script.spells
{
    public class BigBang : Spell
    {
        public override string Name { get { return "BIG BANG"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }
/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -6% Mana 
(Max level 99-12 -4%) Per Cast, Damage would Start (w/ 12 Books) 
707 damage + menCoff, (Max level 99-12 (707damage + menCoff) + 9%)
This spell could be casted only on all enemy's. */
        public override int DamBase { get { return 564; } }//compared to assassin
        public override int DamPl { get { return 13; } }//compared to assassin
        public override int ManaCost { get { return -77; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override int menCoff { get { return 7; } }//compared to assassin
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

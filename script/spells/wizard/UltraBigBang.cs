namespace LKCamelot.script.spells
{
    public class UltraBigBang : Spell
    {
        public override string Name { get { return "ULTRA BIG BANG"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -10% Mana 
(Max level 99-12 -5% Mana) Per Cast, Damage would Start (w/ 12 Books) 507 damage + menCoff, 
(Max level 99-12 (507 damage + menCoff) + 9%) This spell could be casted on all 
Enemy Players/Monster's. */

        public override int DamBase { get { return 397; } }//compared to grandbig bang
        public override int DamPl { get { return 11; } }
        public override int ManaCost { get { return -65; } }
        public override int ManaCostPl { get { return 5; } }
        public override int menCoff { get { return 7; } }//compared to grand big bang
        public override int Range
        {
            get
            {
                return 9;
            }
        }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
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

        public UltraBigBang()
        {
        }
    }
}

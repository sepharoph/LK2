namespace LKCamelot.script.spells
{
    public class ThunderStorm : Spell
    {
        public override string Name { get { return "THUNDER STORM"; } }
        public override int SpellLearnedIcon { get { return 25; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -12% Mana 
(Max level 99-12 -8% Mana) Per Cast, Damage would Start (w/ 12 Books) 
400 damage + menCoff, (Max level 99-12 (400 damage + menCoff) + 9%)
This spell could be casted on all Enemy Players/Monster's. */

        public override int DamBase { get { return 290; } }
        public override int DamPl { get { return 10; } }
        public override int ManaCost { get { return -67; } }
        public override int ManaCostPl { get { return 5; } }
        public override int menCoff { get { return 8; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    10,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public ThunderStorm()
        {
        }
    }
}

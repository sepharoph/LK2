namespace LKCamelot.script.spells
{
    public class DeadlyBoom : Spell
    {
        public override string Name { get { return "DEADLY BOOM"; } }
        public override int SpellLearnedIcon { get { return 69; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -10% Mana 
(Max level 99-12 -5% Mana Per Cast) Per Cast, Damage would Start (w/ 12 Books) 
668 damage + menCoff, (Max level 99-12 (668damage + menCoff) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 533; } }//compared to big bang,assassin,revelation
        public override int DamPl { get { return 15; } }
        public override int ManaCost { get { return -65; } } //65
        public override int ManaCostPl { get { return 5; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override int menCoff { get { return 8; } }
        
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    63,  //impact
                    0,  //thickness
                    3,  //type
                    30,  //speed
                    0  //streak
                    );
            }
        }

        public DeadlyBoom()
        {
        }
    }
}

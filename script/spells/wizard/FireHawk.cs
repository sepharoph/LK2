namespace LKCamelot.script.spells
{
    public class FireHawk : Spell
    {
        public override string Name { get { return "FIRE HAWK"; } }
        public override int SpellLearnedIcon { get { return 14; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -11% Mana 
(Max level 99-12 -8% Mana Per Cast) Per Cast, Damage would Start (w/ 12 Books) 
620 damage + menCoff, (Max level 99-12 (620damage + menCoff) + 9%)
This spell could be casted only on all enemy's. */

        public override int DamBase { get { return 488; } }
        public override int DamPl { get { return 12; } }
        public override int ManaCost { get { return -77; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override int menCoff { get { return 8; } }//compared to other class specific spells
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    27,  //moving
                    00,  //impact
                    0,  //thickness
                    0,  //type
                    9,  //speed
                    1  //streak
                    );
            }
        }

        public FireHawk()
        {
        }
    }
}

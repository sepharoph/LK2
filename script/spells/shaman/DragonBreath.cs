namespace LKCamelot.script.spells
{
    public class DragonBreath : Spell
    {
        public override string Name { get { return "DRAGON BREATH"; } }
        public override int SpellLearnedIcon { get { return 70; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Character Breathe's Fire from Mouth to do damage

Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -10% Mana 
(Max level 99-12 -5%) Per Cast, Damage would Start (w/ 12 Books) 
566 damage + menCoff, (Max level 99-12 (566damage + menCoff) + 9%)
This spell could be casted on all enemy's. */

        public override int DamBase { get { return 456; } }//supposed to do 2nd most single target damage
        public override int DamPl { get { return 10; } }
        public override int ManaCost { get { return -54; } }//compared with other spells
        public override int ManaCostPl { get { return 4; } }//compared with other spells
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Shaman; } }
        public override int menCoff { get { return 9; } }//strong spell
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    7,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public DragonBreath()
        {
        }
    }
}

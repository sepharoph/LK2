namespace LKCamelot.script.spells
{
    public class DragonOfFire : Spell
    {
        public override string Name { get { return "DRAGON OF FIRE"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Summons Fire Dragon to attack Enemy, Similar to FireHawk
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -12% Mana 
(Max level 99-12 -8% Mana Per Cast) Per Cast, Damage would Start (w/ 12 Books) 
709 damage + menCoff, (Max level 99-12 (709 damage + menCoff) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 575; } }
        public override int DamPl { get { return 12; } }
        public override int ManaCost { get { return -78; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override int menCoff { get { return 8; } }
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

        public DragonOfFire()
        {
        }
    }
}

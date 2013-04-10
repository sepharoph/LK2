namespace LKCamelot.script.spells
{
    public class Shock : Spell
    {
        public override string Name { get { return "SHOCK"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -66 Mana 
(Max level 99-12 -22 Mana) Per Cast, Damage would Start (w/ 12 Books) 
85 damage + menCoff, (Max level 99-12 (85 damage + menCoff) + 9%)
This spell could be casted only Monster's level 35 or below. */


        public override int DamBase { get { return 30; } }
        public override int DamPl { get { return 5; } }
        public override int ManaCost { get { return 66; } }//fixed mana cost
        public override int ManaCostPl { get { return 0; } }
        public override int menCoff { get { return 9; } }
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

        public Shock()
        {
        }
    }
}

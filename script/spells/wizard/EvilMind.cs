namespace LKCamelot.script.spells
{
    public class EvilMind : Spell
    {
        public override string Name { get { return "EVIL MIND"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/* SPELL IS ONLY CASTABLE ON MAGICAL MONSTERS & DEMONS! not UNDEAD or PLAYERS

/*Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -312 Mana 
(Max level 99-12 -180 Mana) Per Cast, Damage would Start (w/ 12 Books) 
 damage + menCoff, (Max level 99-12 (880 damage + menCoff) + 9%)
This spell could be casted on all Enemy Players/Monster's. */


        public override int DamBase { get { return 666; } }
        public override int DamPl { get { return 20; } }
        public override int ManaCost { get { return 312; } }//fixed mana cost
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

        public EvilMind()
        {
        }
    }
}

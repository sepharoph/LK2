namespace LKCamelot.script.spells
{
    public class DemonDeath : Spell
    {
        public override string Name { get { return "DEMON DEATH"; } }
        public override int SpellLearnedIcon { get { return 68; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Demon Death dmg equation is (50%Max HP + DEX) Castable every 6 seconds for a cost of -15% HP, ALSO
+10seconds of Freezing Slow by 20%.(when frozen unable to Teleport!)
Level of spell HP Consumed cost and increased damage, Starting at (w/ 12Books) -15% HP
(Max level 99-12 -10% HP) Per Cast, Damage would Start (w/ 12 Books) 
(50%Max HP + DEX), (Max level 99-12 (50%Max HP + DEX) + 9%)
This spell could be casted on all enemy's. */ 

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -50; } }
        public override int ManaCostPl { get { return 3; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Swordsman; } }
        public override int Range { get { return 1; } }
       // public override int dexCoff { get { return 0; } }(Forumla is HalfCurrentHP+DEX), will this fix?
        public override int RecastTime { get { return 6000; } }//6 second cast delay
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    4,  //impact
                    0,  //thickness
                    0,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public DemonDeath()
        {
        }
    }
}

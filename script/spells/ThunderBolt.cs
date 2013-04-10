namespace LKCamelot.script.spells
{
    public class ThunderBolt : Spell
    {
        public override string Name { get { return "THUNDER BOLT"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Effect is a Bolt of Thunder similar to ThunderStorm, but only does damage to Undead/Demon/Animals.
NOT PLAYERS.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -60 Mana 
(Max level 99:12 -30) Per Cast, Damage would Start (w/ 12 Books) 
184 damage, (Max level 99-12 (184 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's. */

        public override int DamBase { get { return 118; } }
        public override int DamPl { get { return 6; } }
        public override int ManaCost { get { return -60; } }
        public override int ManaCostPl { get { return ; } }
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

        public ThunderBolt()
        {
        }
    }
}

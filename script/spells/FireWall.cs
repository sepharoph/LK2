namespace LKCamelot.script.spells
{
    public class FireWall : Spell
    {
        public override string Name { get { return "FIRE WALL"; } }
        public override int SpellLearnedIcon { get { return 17; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* This Effect Creates a 5 square line up to 6 squares from the player, this 5 square line
does damage over time to all monsters standing on the wall, this wall does (w/ 12 books)
218 damage  over 7 seconds. Spell has 10 Second Cooldown so only 1 Fire Wall 
can be up at a time, and each tick of spell can miss if hit too low.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -96 Mana 
(Max level 99:12 -48) Per Cast, Damage would Start (w/ 12 Books) 
218 damage, (Max level 99:12 (218 damage) + 9%)
This spell could be casted on all enemy Player's/Monster's using @pk function. */

        public override int DamBase { get { return 130; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return 96; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0x96,  //impact
                    3,  //thickness
                    0,  //type
                    2,  //speed
                    0  //streak
                    );
            }
        }

        public FireWall()
        {
        }
    }
}

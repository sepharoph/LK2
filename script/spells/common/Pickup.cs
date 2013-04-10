namespace LKCamelot.script.spells
{
    public class Pickup : Spell
    {
        public override string Name { get { return "PICK UP"; } } 
        public override int SpellLearnedIcon { get { return 52; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* Picks up all items in adjacent cells/squares 9 squares, current + 8 surrounding
Leveling this spell decreases mana cost and increases distance of pickup
from (w/ 12 books) -116 per cast (at 99:12 -66mana), distance includes 9 squares, current + 8
(at 99:12 current + surrounding 40 cells/squares(that means 3 squares from the caster
in every direction would have loot picked up) */


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 116; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0,  //impact
                    0,  //thickness
                    3,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public Pickup()
        {
        }
    }
}

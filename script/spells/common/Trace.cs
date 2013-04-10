namespace LKCamelot.script.spells
{
    public class Trace : Spell
    {
        public override string Name { get { return "TRACE"; } } 
        public override int SpellLearnedIcon { get { return 6; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/*This Spell Marked A Location on the map, when spell used aslong 
as in the same map user would be brought to location 
Leveling this spell reduces mana cost, starts at -70 mana, 
(at 99:12 spell costs 20mana)
*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 70; } }
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

        public Trace()
        {
        }
    }
}

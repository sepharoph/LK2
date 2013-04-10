namespace LKCamelot.script.spells
{
    public class Search : Spell
    {
        public override string Name { get { return "SEARCH"; } }
        public override int SpellLearnedIcon { get { return 54; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/*On cast makes items close by to twinkle,
(only works when a magic/spell that makes the environment dark is in effect)
Leveling this spell decreases mana cost starts at -38 (at 99:12 costs 0 mana)*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 38; } }
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

        public Search()
        {
        }
    }
}

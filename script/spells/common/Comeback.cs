﻿namespace LKCamelot.script.spells
{
    public class ComeBack : Spell
    {
        public override string Name { get { return "COME BACK"; } }  //chance village
        public override int SpellLearnedIcon { get { return 54; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

//on cast brings you to village.
//Leveling this spell decreases mana cost starts at -70 (at 99:12 costs -20mana)

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

        public ComeBack()
        {
        }
    }
}

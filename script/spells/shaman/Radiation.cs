namespace LKCamelot.script.spells
{
    public class Radiation : Spell
    {
        public override string Name { get { return "RADIATION"; } }
        public override int SpellLearnedIcon { get { return 65; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Spell Decreased HP & AC by -10% book(s) 1-4((+)-10% 5-8, (+)-20% 9-12, Total of -30% (w/ 12Books) 
removed from HP & AC, Level of spell reduced mana cost and increased duration, Starting at 3minutes 
(Max 5 Minutes 99-12) for buff Mana Cost starts (w/ 12 books) -9% ,(-4% Mana Cost at Max Lvl 99-12).
This spell could be casted on All Players/Monsters to debuff but not on self.
Also message was displayed to the player when counting down to remove effect
    30seconds than 10,5-1 then says Radiation Removed (Sold at Stall)*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -75; } }
        public override int ManaCostPl { get { return 6; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Shaman; } }
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

        public Radiation()
        {
        }
    }
}

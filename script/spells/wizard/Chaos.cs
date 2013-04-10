namespace LKCamelot.script.spells
{
    public class Chaos : Spell
    {
        public override string Name { get { return "CHAOS"; } }
        public override int SpellLearnedIcon { get { return 65; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Enabled the character to find and fight stronger monsters (lvl 11 to 77)
Level of spell reduced mana cost and increased duration, Starting at 3minutes 
(Max 5 Minutes 99:12) for buff Mana Cost starts (w/ 12 books) -17% ,(-7% Mana Cost at Max Lvl 99:12).
This spell could be casted only on self.
Also message was displayed to the player when counting down to remove effect
    30seconds than 10,5-1 then says Chaos Removed */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -50; } }
        public override int ManaCostPl { get { return 3; } }
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

        public Chaos()
        {
        }
    }
}

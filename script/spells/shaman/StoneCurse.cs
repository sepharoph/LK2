namespace LKCamelot.script.spells
{
    public class StoneCurse : Spell
    {
        public override string Name { get { return "STONE CURSE"; } }
        public override int SpellLearnedIcon { get { return 38; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell increased duration of immobilize and reduced mana cost, Starting at 4Seconds 
(Max 10Seconds 99:12) for immobilize debuff. Level of spell also reduced mana cost (w1/ 12 books)
spell costed -10% (Mana Cost -5% Mana at Max Lvl 99:12).
This spell could be casted on All Players/Monsters to debuff but not on self.
Also message was displayed to the player when counting down to remove effect
    30seconds than 10,5-1 then says Stone Curse Removed (Sold at Stall)*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -65; } }
        public override int ManaCostPl { get { return 5; } }
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

        public StoneCurse()
        {
        }
    }
}

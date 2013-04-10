namespace LKCamelot.script.spells
{
    public class Firefly : Spell
    {
        public override string Name { get { return "FIREFLY"; } }
        public override int SpellLearnedIcon { get { return 71; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Spell Decreased HIT by 10%books 1-4(+10%5-8 +10% 9-12, Total of 30% at 12Books removed from HIT, 
Level of spell reduced mana cost and increased duration, Starting at 3minutes (Max 5 Minutes 99-12)
for buff (Mana Cost would give 4% Mana Back at Max Lvl 99-12).
This spell could be casted on players/Monsters to debuff but not on self.
Also message was displayed to the player when counting down to remove effect
    30seconds than 10-1 then says Butterfly Removed (Sold at Stall)*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 48; } }
        public override int ManaCostPl { get { return 4; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
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

        public Firefly()
        {
        }
    }
}

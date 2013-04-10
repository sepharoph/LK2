namespace LKCamelot.script.spells
{
    public class IceBag : Spell
    {
        public override string Name { get { return "ICE BAG"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target; } }

/* Reduces speed of monster or player by 20%, last 4 seconds

Level of spell increased duration of slow and reduces mana cost, Starting at (w/ 12Books) -50 Mana 
(Max level 99:12 -25 Mana) Per Cast, Starting at 4 Seconds Slow Debuff (Max 10Seconds 99:12) 
for slow debuff. This spell could be cast on All Enemy Players/Monsters.
Also message was displayed to the player when counting down to remove effect 
of slow 10,5-1 then says Ice Bag Slow Effect Removed */


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -50; } }
        public override int ManaCostPl { get { return 3; } }
        public override int Range
        {
            get
            {
                return 9;
            }
        }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    65,  //impact
                    0,  //thickness
                    3,  //type
                    3,  //speed
                    0  //streak
                    );
            }
        }

        public X-Ray()
        {
        }
    }
}

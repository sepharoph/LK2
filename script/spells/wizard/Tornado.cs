namespace LKCamelot.script.spells
{
    public class Tornado : Spell
    {
        public override string Name { get { return "TORNADO"; } }
        public override int SpellLearnedIcon { get { return 34; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Reduces Magic Damage By Monsters/Players by 10% lasts 3 minutes, Also message was displayed
to the player when counting down to remove effect 30seconds than 10-1 then says Tornado Removed

Level of spell decreased mana cost and increased duration of debuff
, Starting at (w/ 12Books) -15% Mana (Max level 99-12 -12% Mana) Per Cast, 
Duration would Start (w/ 12 Books) 3 minutes, (Max level 99:12 would last 5 Minutes)
This spell could be casted on all Enemy Players/Monster's. */


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -48; } }
        public override int ManaCostPl { get { return 3; } }
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

        public Tornado()
        {
        }
    }
}

namespace LKCamelot.script.spells
{
    public class WildMonk : Spell
    {
        public override string Name { get { return "WILD MONK"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Summons a Wild Monk, Looks like Monster Monk From Cave, Is Undead, Has 320DMG (+10 per Book)
90AC (+10 per Book) 

Level of spell decreased mana cost and increased Wild Monk's Effectiveness, 
Starting at (w/ 12Books) -26% Mana (Max level 99-12 -22% Mana) 
Per Cast, Wild Monk would Start (w/ 12 Books) 430 DMG and 200 AC, (Max level 99:12 
430 DMG and 180 AC (+20%) = 516DMG and 216 AC */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -70; } }//%based mana usage
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

        public WildMonk()
        {
        }
    }
}

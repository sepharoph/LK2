namespace LKCamelot.script.spells
{
    public class Medusa : Spell
    {
        public override string Name { get { return "MEDUSA"; } }
        public override int SpellLearnedIcon { get { return 64; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Summons a Medusa, Looks like a Monster, Is Demon, Has 0 DMG , Taunts All Mobs on 
caster to Attack Medusa 70AC (+10 per Book), Level of spell decreased mana cost and 
increased Medusa Effectiveness, Starting at (w/ 12Books) -32% Mana (Max level 99-12 -28% Mana) 
Per Cast, Medusa would Start (w/ 12 Books) 180 AC, (Max level 99-12 180 AC +20% */

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return -76; } }
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

        public Medusa()
        {
        }
    }
}

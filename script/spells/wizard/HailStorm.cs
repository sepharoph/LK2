namespace LKCamelot.script.spells
{
    public class HailStorm : Spell
    {
        public override string Name { get { return "HAIL STORM"; } }
        public override int SpellLearnedIcon { get { return 40; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }



/* Does Damage based on spell information and provides slow by 20% for 3 seconds.

Level of spell increased duration and damage, Starting at 3Seconds 
(Max 9Seconds 99-12) for debuff (Damage would increase by 10% at Max Lvl 193Damage 99-12).
This spell could be casted only on self. Also message was displayed to the player 
when counting down to remove effect of slow 5-1 then says Hail Storm Slow Effect
Removed */

        public override int DamBase { get { return 76; } }
        public override int DamPl { get { return 9; } }
        public override int ManaCost { get { return -42; } }
        public override int ManaCostPl { get { return 2; } }
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

        public HailStorm()
        {
        }
    }
}

namespace LKCamelot.script.spells
{
    public class Freezing : Spell
    {
        public override string Name { get { return "FREEZING"; } }
        public override int SpellLearnedIcon { get { return 42; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*Level of spell increased duration of immobilize and damage, Starting at 4Seconds 
(when frozen unable to Teleport!)
(Max 10Seconds 99:12) for slow debuff Damage would Start (w/ 12 Books) 
190 damage + menCoff, (Max level 99:12 (1950damage + menCoff) + 9%)
This spell could be cast on All Enemy Players/Monsters. Also message was displayed 
to the player when counting down to remove effect of freeze/immobilize at 
10 Seconds left on Frozen Effect.,5,4,3,2,1 then says Frozen Effect Removed 
Very Comparable to Stone Curse for Shaman*/

        public override int DamBase { get { return 80; } }
        public override int DamPl { get { return 10; } }
        public override int ManaCost { get { return -60; } }
        public override int ManaCostPl { get { return 4; } }
        public override int menCoff { get { return 9; } }
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

        public Freezing()
        {
        }
    }
}

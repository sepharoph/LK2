namespace LKCamelot.script.spells
{
    public class Oblivion : Spell
    {
        public override string Name { get { return "Oblivion"; } }
        public override int SpellLearnedIcon { get { return 71; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/*This spell should make a monster level 40 + (3 per book) lose agro to 
player for 6 seconds and become confused, also please move to area for non class specific spells*/

        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 46; } }//set to actual 46 mana per cast
        public override int ManaCostPl { get { return 0; } }

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

        public Oblivion()
        {
        }
    }
}

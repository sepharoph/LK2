using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class ShootingStar : Spell
    {
        public override string Name { get { return "SHOOTING STAR"; } }
        public override int SpellLearnedIcon { get { return 24; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* This Spell is supposed to shoot a star from the player. but only does damage to 
Undead/Demon/Animals NOT PLAYERS.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -32 Mana 
(Max level 99-12 -16) Per Cast, Damage would Start (w/ 12 Books) 
184, (Max level 99-12 (184 damage) + 9%)*/

        public override Class ClassReq { get { return Class.Knight | Class.Wizard; } }

        public override int DamBase { get { return 96; } }
        public override int DamPl { get { return 8; } }
        public override int ManaCost { get { return 32; } }
        public override int ManaCostPl { get { return 0; } }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,   //oncast
                    32,  //moving
                    0,   //impact
                    0,   //thickness
                    1,   //type
                    6,   //speed
                    0    //streak
                    );
            }
        }

        public ShootingStar()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LKCamelot.script.spells
{
    public class SoulSprite : Spell
    {
        public override string Name { get { return "SOUL SPRITE"; } }
        public override int SpellLearnedIcon { get { return 24; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Casted; } }

/* This Spell is supposed to summon a Sprite to strike. but only does damage to
Demons & Magical Monsters NOT PLAYERS.
Level of spell decreased mana cost and increased damage, Starting at (w/ 12Books) -132 Mana 
(Max level 99-12 -76) Per Cast, Damage would Start (w/ 12 Books) 
775, (Max level 99-12 (775 damage) + 9%)*/

        public override Class ClassReq { get { return Class.Shaman; } }

        public override int DamBase { get { return 555; } }
        public override int DamPl { get { return 20; } }
        public override int ManaCost { get { return 132; } }
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

        public SoulSprite()
        {
        }
    }
}

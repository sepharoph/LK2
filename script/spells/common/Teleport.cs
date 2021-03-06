﻿namespace LKCamelot.script.spells
{
    public class Teleport : Spell
    {
        public override string Name { get { return "TELEPORT"; } }
        public override int SpellLearnedIcon { get { return 53; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

/* Moves A Player (1 Square/Cell per book max 12 squares) 
Level of spell reduced mana cost increased distance, mana cost would start (w/ 12 books)
-125 (at 99:12 cost is -50 mana). Distance (w/ 12 books) is 12squares/cells (99:12 14 squares/cells)*/


        public override int DamBase { get { return 0; } }
        public override int DamPl { get { return 0; } }
        public override int ManaCost { get { return 125; } }
        public override int ManaCostPl { get { return 0; } }
        public override int RecastTime
        {
            get
            {
                return 3000;
            }
        }

        public void CastIt(model.Player player, LKCamelot.model.Point2D castx)
        {
            if (LKCamelot.model.World.Dist2d(castx.X, castx.Y, player.X, player.Y) <= 7
                && player.MPCur > this.RealManaCost(player))
            {
                player.MPCur -= this.RealManaCost(player);
                this.CheckLevelUp(player);

                player.Loc = new LKCamelot.model.Point2D(castx.X, castx.Y);
                LKCamelot.model.World.SendToAll(new LKCamelot.model.QueDele(player.Map, new LKCamelot.model.MoveSpriteTele(player.Serial, player.Face, player.X, player.Y).Compile()));
                return;
            }
        }

        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0,  //impact
                    0,  //thickness
                    0xff,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public Teleport()
        {
        }
    }
}

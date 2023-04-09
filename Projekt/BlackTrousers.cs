using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class BlackTrousers : DownPart
    {
        public BlackTrousers(Character player) : base(player)
        {
            Invisibility += 13;
            Flexibility += 4;
        }

        public override string MyCharacter()
        {
            return player.MyCharacter() + " wearing black trousers";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class BlueJeans : DownPart
    {
        public BlueJeans(Character player) : base(player)
        {
            Speed += 2;
            Endurance += 5;
        }

        public override string MyCharacter()
        {
            return player.MyCharacter() + " wearing blue jeans";
        }
    }
}

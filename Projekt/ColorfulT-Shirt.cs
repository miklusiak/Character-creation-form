using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class ColorfulT_Shirt : UpperPart
    {
        public ColorfulT_Shirt(Character player) : base(player)
        {
            Camouflage -= 4;
            Flexibility += 7;
            Speed += 2;
        }

        public override string MyCharacter()
        {
            return player.MyCharacter() + " clothed in colorful t-shirt,";
        }
    }
}

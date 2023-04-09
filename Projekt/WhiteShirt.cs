using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class WhiteShirt : UpperPart
    {
        public WhiteShirt(Character player) : base(player)
        {
            Charm = true;
            Flexibility -= 3;
            Experience += 2;
            Camouflage += 13;
        }

        public override string MyCharacter()
        {
            return player.MyCharacter() + " clothed in white shirt,";
        }
    }
}

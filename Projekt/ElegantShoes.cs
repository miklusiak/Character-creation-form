using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class ElegantShoes : Shoes
    {
        public ElegantShoes(Character player): base(player)
        {
            Speed += 3;
            Charm = true;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " with elegant shoes.";
        }
    }
}

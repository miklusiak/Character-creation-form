using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Sneakers : Shoes
    {
        public Sneakers(Character player) : base(player)
        {
            Endurance += 8;
            Experience += 2;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " with sneakers.";
        }
    }
}

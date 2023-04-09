using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class MilitaryBoots : Shoes
    {
        public MilitaryBoots(Character player) : base(player)
        {
            Strength += 10;
            Experience += 3;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " with military boots";
        }
    }
}

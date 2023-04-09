using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class BlackBlouse : UpperPart
    {
        public BlackBlouse(Character player) : base (player)
        {
            Camouflage += 28;
            Invisibility += 26;
            Experience += 4;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " clothed in black fitted blouse,";
        }
    }
}

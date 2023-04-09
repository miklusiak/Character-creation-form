using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class CargoPants : DownPart
    {
        public CargoPants(Character player) : base(player)
        {
            Camouflage += 13;
            Invisibility += 16;
            Endurance += 11;
        }

        public override string MyCharacter()
        {
            return player.MyCharacter() + " wearing cargo pants";
        }
    }
}

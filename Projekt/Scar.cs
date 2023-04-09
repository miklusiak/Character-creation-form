using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Scar : Attribute
    {
        public Scar(Character player) : base(player)
        {
            Speed += 1;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " \nCharacteristic: scar ";
        }
    }
}

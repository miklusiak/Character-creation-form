using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Tattoo : Attribute
    {
        public Tattoo(Character player) : base(player)
        {
            Endurance += 3;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + "\nCharacteristic: tattoo ";
        }
    }
}

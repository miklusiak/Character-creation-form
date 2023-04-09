using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Birthmark : Attribute
    {
        public Birthmark(Character player) : base(player)
        {
            Experience += 2;
        }
        public override string MyCharacter()
        {
            return player.MyCharacter() + " \nCharacteristic: birthmark ";
        }
    }
}

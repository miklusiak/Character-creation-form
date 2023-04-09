using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Dancer : Woman
    {
        public Dancer() : base()
        {
            Flexibility += 24;
            Charm = true;
            Endurance += 50;
            Invisibility += 14;
        }

        public override string MyCharacter()
        {
            return "Kate";
        }
    }
}

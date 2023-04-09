using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Soldier : Man
    {
        public Soldier() : base()
        {
            Strength += 30;
            Endurance += 45;
            Charm = true;
            Experience += 10;
        }
        public override string MyCharacter()
        {
            return "Michael";
        }
    }
}

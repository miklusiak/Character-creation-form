using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Receptionist : Woman
    {
        public Receptionist() : base()
        {
            Cleverness = true;
            Patience = true;
            Flexibility += 6; 
        }
        public override string MyCharacter()
        {
            return "Juliet";
        }
    }
}

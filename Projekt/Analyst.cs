using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Analyst : Woman
    {
        public Analyst() : base()
        {
            Cleverness = true;
            Patience = true;
            Speed += 13;
        }
        public override string MyCharacter()
        {
            return "Sara";
        }
    }
}

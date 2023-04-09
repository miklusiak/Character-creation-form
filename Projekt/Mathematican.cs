using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Mathematician : Man
    {
        public Mathematician() : base()
        {
            Cleverness = true;
            Patience = true;
            Speed += 11;
        }
        public override string MyCharacter()
        {
            return "Mattihas";
        }
    }
}

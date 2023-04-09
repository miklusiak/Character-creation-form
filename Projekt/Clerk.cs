using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Clerk : Man
    {
        public Clerk() : base()
        {
            Cleverness = true;
            Speed += 14;
            Charm = true;
        }
        public override string MyCharacter()
        {
            return "Gavin";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    abstract public class Man : Character
    {
        public Man() : base()
        {
            Strength += 20;
        }
    }
}

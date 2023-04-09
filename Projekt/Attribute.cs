using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public abstract class Attribute : CharacterDecorator
    {
        public Attribute(Character player) : base(player)
        {
            Invisibility -= 2;
        }
    }
}

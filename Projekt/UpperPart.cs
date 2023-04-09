using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public abstract class UpperPart : CharacterDecorator
    {
        public UpperPart(Character player) : base(player)
        {
            Camouflage += 6;
            Invisibility += 8;
        }
    }
}

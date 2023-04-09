using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public abstract class DownPart : CharacterDecorator
    {
        public DownPart(Character player) : base(player)
        {
            Invisibility += 6;
            Endurance += 3;
        }
    }
}

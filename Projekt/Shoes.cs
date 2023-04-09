using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public abstract class Shoes : CharacterDecorator
    {
        public Shoes(Character player) : base(player)
        {
            Endurance += 5;
        }
    }
}

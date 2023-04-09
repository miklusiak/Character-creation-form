using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public enum Direction { Up, Down, Left, Right, None }
    public abstract class Character
    {
        public virtual int Endurance { get; set; } = 15;    // possible incrased phisical activity in minutes
        public virtual int Speed { get; set; } = 8;     // solved given problems (enigma/puzzle) in 1hour 
        public virtual int Strength { get; set; } = 20;     // weight wchih can pick up and hold for 10minutes standing 
        public virtual int Flexibility { get; set; } = 11;      // movement range in percent
        public virtual bool Cleverness { get; set; } = false;       // creative solutions
        public virtual bool Patience { get; set; } = false;
        public virtual bool Charm { get; set; } = false;

        // special features - adaptation
        public virtual int Camouflage { get; set; } = 10; // in percentages
        public virtual int Experience { get; set; } = 0; // in years
        public virtual int Invisibility { get; set; } = 10; // in percentages

        public virtual string MyCharacter()
        {
            return "Anonym";
        }

    }
}

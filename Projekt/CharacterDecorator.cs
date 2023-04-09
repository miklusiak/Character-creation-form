using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public abstract class CharacterDecorator : Character
    {
        protected Character player;

        public override int Endurance { get => player.Endurance; set =>player.Endurance = value; } 
        public override int Speed { get => player.Speed; set => player.Speed = value; }
        public override int Strength { get => player.Strength; set => player.Strength = value; }
        public override int Flexibility { get => player.Flexibility; set => player.Flexibility = value; } 
        public override bool Cleverness { get => player.Cleverness; set => player.Cleverness = value; } 
        public override bool Patience { get => player.Patience; set => player.Patience = value; } 
        public override bool Charm { get => player.Charm; set => player.Charm = value; }

        public override int Camouflage { get => player.Camouflage; set => player.Camouflage = value; }
        public override int Experience { get => player.Experience; set => player.Experience = value; }
        public override int Invisibility { get => player.Invisibility; set => player.Invisibility = value; }

        public CharacterDecorator(Character character)
        {
            player = character;
        }
    }
}

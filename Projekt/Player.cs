using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Player 
    {
        private char symbol;
        private ConsoleColor color;        
        public Direction Direction { get; set; } = Direction.Right;
        private Move Position { get; set; } = new Move();
        public List<Move> Point { get; set; } = new List<Move>();
        private int Length { get; } = 1;

        public Player(Character one, char _symbol, ConsoleColor _color)
        {
            symbol = _symbol;
            color = _color;
        }
        
        public void Run()
        {
            Console.CursorVisible = false;
            NearSafe();

            if (Triumph())
            {
                Direction = Direction.None;
                End.MissionComplete();
                return;
            }

            switch (Direction)
            {
                case Direction.Left:
                    Position.X--;
                    break;
                case Direction.Right:
                    Position.X++;
                    break;
                case Direction.Up:
                    Position.Y--;
                    break;
                case Direction.Down:
                    Position.Y++;
                    break;
                case Direction.None:
                    Position.X = Position.X;
                    Position.Y = Position.Y;
                    break;
            }

            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Point.Add(new Move(Position.X, Position.Y));

            if (Point.Count > Length)
            {
                var endpoint = Point.First();
                Console.SetCursorPosition(endpoint.X, endpoint.Y);
                Console.Write(" ");
                Point.Remove(endpoint);
            }            
        }
        public bool AbleToMove(params List<Move>[] obstacles)
        {
            //kod do debugowana pozdrawiam Michała <3
            /*n1.ElementAt(0).WriteMove();
            Position.WriteMove();*/

            bool contains = false;

            foreach(List<Move> list in obstacles)
            {
                foreach (Move a in list)
                {
                    if (a.X == Position.X && a.Y == Position.Y)                    
                    {
                        contains = true;
                        break;
                    }
                }
                if (contains) break;
            }            
            return !contains;            
        }
        public bool Triumph()
        {
            if (Position.X == 40 && Position.Y == 20)
                return true;
            else
                return false;
        }
        public void NearSafe()
        {
            if (37 < Position.X && Position.X < 43 && 17 < Position.Y && Position.Y < 23)
            {
                Console.SetCursorPosition(40, 20);
                Console.Write("X", Console.ForegroundColor = ConsoleColor.Red);
                Console.SetCursorPosition(Position.X, Position.Y);
            }
                        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Projekt
{
    public class NPC 
    {
        private readonly Character runner;       
        private Move Position { get; set; } = new Move();
        private List<Move> Point { get; set; } = new List<Move>();
        private int pfx;
        private int pfy;
        public static bool exit = true;

        public NPC(Character _runner, int pstx, int psty, int _pfx, int _pfy)
        {
            runner = _runner;
            Position.X = pstx;
            Position.Y = psty;
            pfx = _pfx;
            pfy = _pfy;
        }
        public void RunRunner()
        {
            Console.CursorVisible = false;
            int stx = Position.X;
            int sty = Position.Y;
            
            while(exit)
            {
                while (Position.X < pfx)
                { 
                    ShowMe();
                    Position.X++;
                    Thread.Sleep(250);
                }
                while (Position.X > pfx)
                {
                    ShowMe();
                    Position.X--;
                    Thread.Sleep(250);
                }
                while (Position.Y < pfy)
                {
                    ShowMe();
                    Position.Y++;
                    Thread.Sleep(250);
                }
                while (Position.Y > pfy)
                {
                    ShowMe();
                    Position.Y--;
                    Thread.Sleep(250);
                }
                pfx = stx;
                pfy = sty;
                stx = Position.X;
                sty = Position.Y;                
            }            
        }
        public void ShowMe()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("&");
            Point.Add(new Move(Position.X, Position.Y));

            if (Point.Count > 1)
            {
                var endpoint = Point.First();
                Console.SetCursorPosition(endpoint.X, endpoint.Y);
                Console.Write(" ");
                Point.Remove(endpoint);
            }
        }
    }
}

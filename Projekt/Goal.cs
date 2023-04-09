using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projekt
{
    class Goal
    {        
        private bool exit = false;
        private double moveTime = 1000 / 4.0;
        private DateTime lastDate = DateTime.Now;
        readonly List<Move> wall = new List<Move>();
        readonly List<Move> fence = new List<Move>();
        readonly List<Move> furniture = new List<Move>();

        readonly int Width = 118;
        readonly int Height = 28;

        public void CreatingMap()
        {
            int i = 0;            
            Console.Clear();
            //fence
            for ( i = 0; i < Width; i++)
            {
                Move added = new Move(i, 0);
                fence.Add(added);
            }
            for (i = 0; i < Height; i++)
            {
                Move added = new Move(0, i);
                fence.Add(added);
            }
            for ( i = 0; i < Width; i++)
            {
                Move added = new Move(i, Height);
                fence.Add(added);
            }
            for ( i = 0; i < Height + 1; i++)
            {
                Move added = new Move(Width, i);
                fence.Add(added);
            }
            //walls
            for ( i = 4; i < 13; i++)
            {
                Move addWall = new Move(35, i);
                wall.Add(addWall);
            }
            for (i = 14; i < 26; i++)
            {
                Move addWall = new Move(35, i);
                wall.Add(addWall);
            }
            for (i = 35; i < 109; i++)
            {
                Move addWall = new Move(i, 4);
                wall.Add(addWall);
            }
            for (i = 4; i < 26; i++)
            {
                Move addWall = new Move(108, i);
                wall.Add(addWall);
            }
            for (i = 35; i < 109; i++)
            {
                Move addWall = new Move(i, 25);
                wall.Add(addWall);
            }             
            for(i = 35; i < 88; i++)
            {
                Move addWall = new Move(i, 16);
                wall.Add(addWall);
            }
            for(i = 17; i < 24; i++)
            {
                Move addWall = new Move(65, i);
                wall.Add(addWall);
            }
            for(i = 18; i < 26 ; i++)
            {
                Move addWall = new Move(50, i);
                wall.Add(addWall);
            }          
            for(i = 6; i < 12; i++)
            {
                Move addWall = new Move(50, i);
                wall.Add(addWall);
            }
            for (i = 35; i < 66; i++)
            {
                Move addWall = new Move( i, 12);
                wall.Add(addWall);
            }
            for (i = 5; i < 9; i++)
            {
                Move addWall = new Move( 65, i);
                wall.Add(addWall);
            }
            for (i = 16 ; i < 26; i++)
            {
                Move addWall = new Move(97,i);
                wall.Add(addWall);
            }
            for (i = 101 ; i < 108; i++)
            {
                Move addWall = new Move(i, 16);
                wall.Add(addWall);
            }
            for (i = 90; i < 100 ; i++)
            {
                Move addWall = new Move(i, 16);
                wall.Add(addWall);
            }
            //furniture            
            for (i = 36; i < 42; i++)
            {
                Move addfur = new Move(i, 15);
                furniture.Add(addfur);
            }
            for (i = 5; i < 11; i++)
            {
                Move addfur = new Move(36, i);
                furniture.Add(addfur);
            }
            for (i = 36; i <49 ; i++)
            {
                Move addfur = new Move(i, 11);
                furniture.Add(addfur);
            }
            for (i = 6; i < 11; i++)
            {
                Move addfur = new Move(51,i);
                furniture.Add(addfur);
            }
            for (i = 105; i < 108; i++)
            {
                for(int j = 23; j < 25; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }                
            }
            for (i = 36 ; i < 49 ; i++)
            {
                Move addfur = new Move(i, 24);
                furniture.Add(addfur);
            }
            for (i = 70; i < 75; i++)
            {
                for(int j = 17; j< 21;j++)
                {
                    Move addfur = new Move(i,j);
                    furniture.Add(addfur);
                }                
            }
            for (i = 75; i < 80; i++)
            {
                for (int j = 6; j < 13; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 90; i < 100; i++)
            {
                for (int j = 11; j < 14 ; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 106 ; i < 108 ; i++)
            {
                for (int j = 5; j < 15; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 93; i < 97; i++)
            {
                for (int j = 7; j < 9; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 87; i < 92; i++)
            {
                for (int j = 19; j < 22; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 51; i < 54; i++)
            {
                for (int j = 18; j < 25; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            for (i = 62; i < 65; i++)
            {
                for (int j = 17; j < 24; j++)
                {
                    Move addfur = new Move(i, j);
                    furniture.Add(addfur);
                }
            }
            
            //drawing
            foreach (Move a in wall)
            {
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write("#", Console.ForegroundColor = ConsoleColor.Gray);
            }
            foreach (Move a in fence)
            {
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write("|", Console.ForegroundColor = ConsoleColor.Green);
            }
            foreach (Move a in furniture)
            {
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write("@", Console.ForegroundColor = ConsoleColor.Magenta);
            }

            Danger.Participants();
        }

        /*public void CreatingFirstFloor()
        {
        //ambicje poniosły
            int i = 0;
            //walls
            Console.Clear();
            wall.Clear();
            furniture.Clear();

            for (i = 4; i < 26; i++)
            {
                Move addWall = new Move(35, i);
                wall.Add(addWall);
            }
            for (i = 35; i < 109; i++)
            {
                Move addWall = new Move(i, 4);
                wall.Add(addWall);
            }
            for (i = 4; i < 26; i++)
            {
                Move addWall = new Move(108, i);
                wall.Add(addWall);
            }
            for (i = 35; i < 109; i++)
            {
                Move addWall = new Move(i, 25);
                wall.Add(addWall);
            }
            for (i = 4; i < 26; i++)
            {
                Move addWall = new Move( 80, i);
                wall.Add(addWall);
            }
            //drawing
            foreach (Move a in wall)
            {
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write("#", Console.ForegroundColor = ConsoleColor.Gray);
            }
            foreach (Move a in furniture)
            {
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write("@", Console.ForegroundColor = ConsoleColor.Magenta);
            }

        }*/
        public void Draw(Player p1)
        {
            Console.Clear();
            CreatingMap();
            p1.NearSafe();
                        
            Console.ReadKey();
            while(!exit)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;

                        case ConsoleKey.LeftArrow:
                            if (p1.AbleToMove(wall, fence, furniture) && !p1.Triumph())
                            {
                                p1.Direction = Direction.Left;

                            }
                            else if (p1.AbleToMove(wall, fence, furniture) && p1.Triumph())
                            {
                                p1.Direction = Direction.None;
                                End.MissionComplete();
                            }
                            else
                            {
                                p1.Direction = Direction.None;
                                Console.ReadKey();
                                End.Defeat();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (p1.AbleToMove(wall, fence, furniture) && !p1.Triumph())
                            {
                                p1.Direction = Direction.Right;
                            }                                
                            else if (p1.AbleToMove(wall, fence, furniture) && p1.Triumph())
                            {
                                p1.Direction = Direction.None;
                                End.MissionComplete();
                            }
                            else
                            {
                                p1.Direction = Direction.None;
                                Console.ReadKey();
                                End.Defeat();
                                exit = true;
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            if (p1.AbleToMove(wall, fence, furniture) && !p1.Triumph())
                            { 
                                p1.Direction = Direction.Up;
                            }
                            else if (p1.AbleToMove(wall, fence, furniture) && p1.Triumph() )
                            {
                                p1.Direction = Direction.None;
                                End.MissionComplete();
                            }
                            else
                            {
                                p1.Direction = Direction.None;
                                Console.ReadKey();
                                End.Defeat();
                                exit = true;
                            }                                
                            break;

                        case ConsoleKey.DownArrow:
                            if (p1.AbleToMove(wall, fence, furniture) && !p1.Triumph())
                            {
                                p1.Direction = Direction.Down;
                            }
                            else if (p1.AbleToMove(wall, fence, furniture) && p1.Triumph())
                            {
                                p1.Direction = Direction.None;
                                End.MissionComplete();
                            }
                            else
                            {
                                p1.Direction = Direction.None;
                                Console.ReadKey();
                                End.Defeat();
                                exit = true;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            p1.Direction = Direction.None;
                            break;
                    }
                }
                if((DateTime.Now - lastDate).TotalMilliseconds >= moveTime && p1.AbleToMove(wall, fence, furniture))
                {
                    p1.Run();
                    lastDate = DateTime.Now;
                }
            }

        }                     
    }
}

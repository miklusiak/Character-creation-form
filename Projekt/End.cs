using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projekt
{
    public class End
    {
        public static void MissionComplete()
        {
            Console.Clear();
            Danger.Kill();
            Console.SetCursorPosition((Console.WindowWidth - 18) / 2, (Console.WindowHeight - 6)/ 2);
            Console.WriteLine(" Well Done! ");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);
        }

        public static void Defeat()
        {
            Console.Clear();
            Danger.Kill();
            Console.SetCursorPosition((Console.WindowWidth - 18)/ 2, (Console.WindowHeight - 6) / 2);
            Console.WriteLine(" You have lost! ");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);
        }
    }
}

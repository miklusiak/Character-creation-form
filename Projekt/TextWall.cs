using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public static class TextWall
    {
        public static void Menu1Text()
        {
            Console.WriteLine("Choose sex of your character");
            Console.WriteLine("");
            Console.WriteLine("1 - WOMAN ");
            Console.WriteLine("");
            Console.WriteLine("2 - MAN ");
            Console.WriteLine("");
        }
        public static void WomanText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose work faculty and name ");
            Console.WriteLine("");
            Console.WriteLine("1 - Dancer 'Kate' ");
            Console.WriteLine("");
            Console.WriteLine("2 - Analyst 'Sara' ");
            Console.WriteLine("");
            Console.WriteLine("3 - Receptionist 'Juliet' ");
            Console.WriteLine("");
        }
        public static void ManText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose work faculty and name ");
            Console.WriteLine("");
            Console.WriteLine("1 - Soldier 'Michael' ");
            Console.WriteLine("");
            Console.WriteLine("2 - Mathematician 'Mattihas' ");
            Console.WriteLine("");
            Console.WriteLine("3 - Clerk 'Gavin' ");
            Console.WriteLine("");
        }
        public static void UpText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose upper part of clothing ");
            Console.WriteLine("");
            Console.WriteLine("1 - black blouse (camouflage +28, invisibility +26, experience +4)");
            Console.WriteLine("");
            Console.WriteLine("2 - colorful T-shirt (camouflage -4, flexibility +7, speed +2)");
            Console.WriteLine("");
            Console.WriteLine("3 - white shirt (charm, flexibility -3, experience +2, camouflage +13)");
            Console.WriteLine("");
        }
        public static void DownText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose down part of clothing ");
            Console.WriteLine("");
            Console.WriteLine("1 - black trousers (invisibility +13, flexibility +4)");
            Console.WriteLine("");
            Console.WriteLine("2 - cargo pants (camouflage +13, invisibility +16, endurance +11)");
            Console.WriteLine("");
            Console.WriteLine("3 - blue jeans (speed +2, endurance +5)");
            Console.WriteLine("");

        }
        public static void ShoesText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose shoes ");
            Console.WriteLine("");
            Console.WriteLine("1 - sneakers (endurnace +8, experience +2)");
            Console.WriteLine("");
            Console.WriteLine("2 - military boots (strength +10, experience +3)");
            Console.WriteLine("");
            Console.WriteLine("3 - elegant shoes (charm, speed +3)");
            Console.WriteLine("");
        }
        public static void AttributeText()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose character's attribute ");
            Console.WriteLine("");
            Console.WriteLine("1 - tattoo (endurance +3)");
            Console.WriteLine("");
            Console.WriteLine("2 - scar (speed +1)");
            Console.WriteLine("");
            Console.WriteLine("3 - birthmark (experience +2)");
            Console.WriteLine("");
        }
        public static void Introduction()
        {
            Console.Write("Let's play a game!" +
                "\nThere is one house one mission one chance and you. \nYou can choose the character and some visual faeatures. \nEvery decision will change character's parameters. " +
                "\nLater your mission will be get to X on the map without any problems. " +
                "\nGreen '/'s symbolize fence, white '#' - walls, magneta '@' are in positions of furniture. \nIf you will go on them yoou will loose. " +
                "\nOther characters will be sign by yellow '&', you are blue '$'. \nSafe will be visible as red 'X' wchich will be visible when you'll be enough close. " +
                "\nTo win you have to stand on 'X'. ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Agent 013, \nwe have new mission for you. Object we watch for six months took irregular action. \nNext week he organize party for celebrities in his house." +
                " \nYour mission is to get into his house this night and get to his safe. \nEnsure that you will have everything you will need because you can have only clothes, " +
                "\neveryone will be checked before coming into the house. ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

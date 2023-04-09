using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class CreatingMenu1
    {        
        public static void Menu1()
        {
            int stop = 0;
            Console.Title = "Creating Character";

            while(stop<1 )
            {
                TextWall.Menu1Text();

                ConsoleKeyInfo menu1 = Console.ReadKey();                               

                switch (menu1.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        MenuMethods.ChooseWoman();

                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        MenuMethods.ChooseWoman();

                        break;
                    case ConsoleKey.D2:
                        Console.Clear(); 
                        MenuMethods.ChooseMan();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        MenuMethods.ChooseMan();
                        break;
                        
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }            
        }
        public static void Menu2Woman()
        {
            int stop = 0;

            while (stop<1)
            {
                TextWall.WomanText();

                ConsoleKeyInfo menu2 = Console.ReadKey();

                switch(menu2.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Dancer s1 = new Dancer();
                        MenuMethods.DecoreUp(s1);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Dancer s2 = new Dancer();
                        MenuMethods.DecoreUp(s2);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Analyst s3 = new Analyst();
                        MenuMethods.DecoreUp(s3);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Analyst s4 = new Analyst();
                        MenuMethods.DecoreUp(s4);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Receptionist s5 = new Receptionist();
                        MenuMethods.DecoreUp(s5);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Receptionist s6 = new Receptionist();
                        MenuMethods.DecoreUp(s6);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
        public static void Menu2Man()
        {
            int stop = 0;

            while (stop<1)
            {
                TextWall.ManText();
                
                ConsoleKeyInfo menu3 = Console.ReadKey();

                switch (menu3.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Soldier s1 = new Soldier();
                        MenuMethods.DecoreUp(s1);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Soldier s2 = new Soldier();
                        MenuMethods.DecoreUp(s2);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Mathematician s3 = new Mathematician();
                        MenuMethods.DecoreUp(s3);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Mathematician s4 = new Mathematician();
                        MenuMethods.DecoreUp(s4);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Clerk s5 = new Clerk();
                        MenuMethods.DecoreUp(s5);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Clerk s6 = new Clerk();
                        MenuMethods.DecoreUp(s6);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
        public static void MenuUpperPart(Character s1)
        {
            MenuMethods.CreatedToPlay(s1);

            int stop = 0;
            while (stop < 1)
            {
                TextWall.UpText();

                ConsoleKeyInfo menuup = Console.ReadKey();

                switch (menuup.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        BlackBlouse s2 = new BlackBlouse(s1);
                        MenuMethods.DecoreDown(s2);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        BlackBlouse s3 = new BlackBlouse(s1);
                        MenuMethods.DecoreDown(s3);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        ColorfulT_Shirt s4 = new ColorfulT_Shirt(s1);
                        MenuMethods.DecoreDown(s4);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ColorfulT_Shirt s5 = new ColorfulT_Shirt(s1);
                        MenuMethods.DecoreDown(s5);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        WhiteShirt s6 = new WhiteShirt(s1);
                        MenuMethods.DecoreDown(s6);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        WhiteShirt s7 = new WhiteShirt(s1);
                        MenuMethods.DecoreDown(s7);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
        public static void MenuDownPart(Character s2)
        {
            MenuMethods.CreatedToPlay(s2);

            int stop = 0;
            while (stop < 1)
            {
                TextWall.DownText();

                ConsoleKeyInfo menu = Console.ReadKey();

                switch (menu.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        BlackTrousers s3 = new BlackTrousers(s2);
                        MenuMethods.DecoreShoe(s3);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        BlackTrousers s4 = new BlackTrousers(s2);
                        MenuMethods.DecoreShoe(s4);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        CargoPants s5 = new CargoPants(s2);
                        MenuMethods.DecoreShoe(s5);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        CargoPants s6 = new CargoPants(s2);
                        MenuMethods.DecoreShoe(s6);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        BlueJeans s7 = new BlueJeans(s2);
                        MenuMethods.DecoreShoe(s7);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        BlueJeans s8 = new BlueJeans(s2);
                        MenuMethods.DecoreShoe(s8);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
        public static void MenuShoes(Character s3)
        {
            MenuMethods.CreatedToPlay(s3);

            int stop = 0;
            while (stop < 1)
            {
                TextWall.ShoesText();

                ConsoleKeyInfo menu = Console.ReadKey();

                switch (menu.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Sneakers s4 = new Sneakers(s3);
                        MenuMethods.DecoreAttribute(s4);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Sneakers s5 = new Sneakers(s3);
                        MenuMethods.DecoreAttribute(s5);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        MilitaryBoots s6 = new MilitaryBoots(s3);
                        MenuMethods.DecoreAttribute(s6);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        MilitaryBoots s7 = new MilitaryBoots(s3);
                        MenuMethods.DecoreAttribute(s7);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ElegantShoes s8 = new ElegantShoes(s3);
                        MenuMethods.DecoreAttribute(s8);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        ElegantShoes s9 = new ElegantShoes(s3);
                        MenuMethods.DecoreAttribute(s9);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
        public static void MenuAttribute(Character s4)
        {            
            MenuMethods.CreatedToPlay(s4);

            int stop = 0;
            while (stop < 1)
            {
                TextWall.AttributeText();

                ConsoleKeyInfo menu = Console.ReadKey();

                switch (menu.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Tattoo s5 = new Tattoo(s4);
                        MenuMethods.CreatedToPlay(s5);
                        MenuMethods.GoToGoal(s5);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Tattoo s6 = new Tattoo(s4);
                        MenuMethods.CreatedToPlay(s6);
                        MenuMethods.GoToGoal(s6);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Scar s7 = new Scar(s4);
                        MenuMethods.CreatedToPlay(s7);
                        MenuMethods.GoToGoal(s7);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Scar s8 = new Scar(s4);
                        MenuMethods.CreatedToPlay(s8);
                        MenuMethods.GoToGoal(s8);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Birthmark s9 = new Birthmark(s4);
                        MenuMethods.CreatedToPlay(s9);
                        MenuMethods.GoToGoal(s9);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Birthmark s10 = new Birthmark(s4);
                        MenuMethods.CreatedToPlay(s10);
                        MenuMethods.GoToGoal(s10);
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                stop++;
            }
        }
    }
}

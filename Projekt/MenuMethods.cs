using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Projekt
{
    public static class MenuMethods
    {
        public static void ChooseWoman()
        {
            Console.WriteLine("");
            Console.WriteLine("Creating woman");
            Console.WriteLine("");
            CreatingMenu1.Menu2Woman();
        }
        public static void ChooseMan()
        {
            Console.WriteLine("");
            Console.WriteLine("Creating man");
            Console.WriteLine("");
            CreatingMenu1.Menu2Man();
        }              
        public static void DecoreUp(Character s1)
        {
            //JSON(s1);
            CreatingMenu1.MenuUpperPart(s1);
        }
        public static void DecoreDown(Character s2)
        {
            //JSON(s2);
            CreatingMenu1.MenuDownPart(s2);
        }
        public static void DecoreShoe(Character s3)
        {
            //JSON(s3);
            CreatingMenu1.MenuShoes(s3);
        }
        public static void DecoreAttribute(Character s4)
        {
            //JSON(s4);
            CreatingMenu1.MenuAttribute(s4);
        }
        public static void CreatedToPlay(Character s5)
        {
            JSON(s5);
            Console.WriteLine(s5.MyCharacter());
            Console.WriteLine("Endurance: " + s5.Endurance + "\nSpeed: " + s5.Speed + "\nStrength: " + s5.Strength 
                + "\nFlexibility: " + s5.Flexibility + "\nCleverness: " + s5.Cleverness + "\nPatience: " + s5.Patience 
                + "\nCharm: " + s5.Charm + "\nCamouflage: " + s5.Camouflage + "\nExperience: " + s5.Experience 
                + "\nInvisibility: " + s5.Invisibility);
            //Console.ReadKey();
        }
        public static void GoToGoal(Character s6)
        {
            //JSON(s6);
            Player one = new Player(s6, '$', ConsoleColor.Blue);
            Goal board = new Goal();
            board.Draw(one);
        }
        public static void JSON(Character s7)
        { 
            string filename = @"C:\Users\kryst\source\repos\Projekt\json";
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
            string jsons6 = JsonSerializer.Serialize(s7, options);

            try { File.WriteAllText(filename, jsons6); }
            catch (Exception) { Exception ex = new Exception(); Console.WriteLine($"\nException: \n{ex.Message}"); }
            /*
            Console.WriteLine("");
            Console.WriteLine(jsons6);
            Console.ReadKey();*/
        }
    }
}

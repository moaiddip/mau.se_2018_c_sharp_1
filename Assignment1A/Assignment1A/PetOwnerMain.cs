using System;
using System.Collections.Generic;

namespace Assignment1A
{
    class PetOwnerMain
    {
        private static bool exit = false;
        private static List<string> menuItems = new List<string>();

        static void Main(string[] args)
        {
            while (!exit)
            {
                Console.Clear();
                Welcome();
                Menu();
                ReadInput();
            }

            Pet pet = new Pet();

            pet.ReadValues();
            pet.ToString();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static string ReadInput()
        {
            while(!Int32.TryParse(Console.ReadLine(), out int opt)){
            }
        }

        private static void Menu()
        {
            

            menuItems.Add("Your Pet");
            menuItems.Add("Corporative Math");

            menuItems.Add("Exit");
            
            // Displaying menu

        }

        private static string getDate()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(assembly.Location);
            DateTime lastModified = fileInfo.LastWriteTime;
            string returnDate = $"{lastModified.Year}-{lastModified.Month}";
            return returnDate;
        }

        private static void Welcome()
        {
            Console.WriteLine($"!-----------WELCOME TO-------!");
            Console.WriteLine($"!  ASSIGNMENT 1              !");
            Console.WriteLine($"!     Michal Sitarczuk       !");
            Console.WriteLine($"!        Malmö Universitet   !");
            Console.WriteLine($"!                  {getDate()}   !");
            Console.WriteLine($"!----------------------------!");
            Console.WriteLine($"\n\n\n");
        }



    }
}

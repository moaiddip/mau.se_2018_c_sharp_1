using System;

namespace Assignment1A
{
    class PetOwnerMain
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();

            pet.ReadValues();
            pet.ToString();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

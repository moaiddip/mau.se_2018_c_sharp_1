using System;
using System.Diagnostics;
using System.Text;

namespace Assignment1A
{
    internal class Pet
    {
        private string name;
        private int age;
        private bool isFemale;
        private string gender;

        public Pet()
        {
        }

        public void ReadValues()
        {
            /// Section to read NAME
            Console.WriteLine("What is the name of your pet?");

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter valid name in form of a non-empty string.");
                name = Console.ReadLine();
            }
            Debug.WriteLine($"Name of your pet is {name}");

            /// Section to read AGE
            Console.WriteLine($"How old is {name}? (Use numeric input in years.)");

            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please enter valid integer.");
            }

            Debug.WriteLine($"Age of your pet is {age}");

            /// Section to read GENDER
            Console.WriteLine($"What is gender of {name}? (male/female)");

            while (gender == null)
            {
                string tmp = Console.ReadLine();

                switch (tmp.ToLowerInvariant())
                {
                    case "m":
                    case "male":
                        isFemale = false;
                        break;
                    case "f":
                    case "female":
                        isFemale = true;
                        break;
                    default:
                        Console.WriteLine("Valid answers: m, male, f, female.");
                        return;
                }

                gender = isFemale ? "Female" : "Male";
                Debug.WriteLine($"Gender of your pet is {gender.ToLower()}");
            }
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.AppendLine("\n---------------------------------------------------");
            returnString.AppendLine($"Name of your pet is {name}.\n{name} is {age} year(s) old.\n{name} is {gender.ToLower()}.");
            returnString.AppendLine("---------------------------------------------------\n");
            Debug.WriteLine(returnString.ToString());
            Console.WriteLine(returnString.ToString());
            return returnString.ToString();
        }
    }
}

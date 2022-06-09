using System;
using System.Linq;

namespace CatExample
{
    class Cat
    {
        string name;
        string favouriteToy;
        DateTime dateOfBirth;
        string breed;

        public static void Welcome()
        {
            Console.WriteLine("Welcome to my cat application");
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

        static bool InCatShow(string breed)
        {
            string[] catBreeds = { "Siamese", "Ragdoll", "Persian", "Javanese", "Bengal" };

            if (catBreeds.Contains(breed)) {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // lets create an object
            Cat bengal = new Cat();

            // access static method
            Welcome();


            // use the fields
            
            // ask values from user
            Console.WriteLine("What is your cat name?");
            bengal.name = Console.ReadLine();

            Console.WriteLine("What is your cat favourite toy?");
            bengal.favouriteToy = Console.ReadLine();

            // assign values
            bengal.breed = "Bengal";
            bengal.dateOfBirth = new DateTime(2020, 12, 24);

            // print stuff
            Console.WriteLine("");
            Console.WriteLine(bengal.name + " says: ");
            bengal.Meow();
            Console.WriteLine("\nfavourite toy is: " + bengal.favouriteToy);
            Console.WriteLine(bengal.name + " is born " + bengal.dateOfBirth.ToString("dd.MM.yyyy"));

            // access static method
            if (InCatShow(bengal.breed))
            {
                Console.WriteLine(bengal.name + " attending to the cat show!");
            }


            //if (!InCatShow("Persian"))
            //{
            //    Console.WriteLine("\nPersian cats are attending in the cat show");
            //}

            Console.ReadLine();

        }
    }
}
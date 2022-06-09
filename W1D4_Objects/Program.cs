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

        public void meow()
        {
            Console.WriteLine("Meow!");
        }

        static bool inCatShow(string breed)
        {
            string[] catBreeds = { "siamese", "ragdoll", "persian", "javanese", "bengal" };

            if (catBreeds.Contains(breed)) {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // lets create an object
            Cat bengal = new Cat();

            // access the method
            bengal.meow();

            // use the fields
            bengal.name = "Bella";
            bengal.favouriteToy = "Mouse";
            bengal.breed = "Bengal";
            bengal.dateOfBirth = new DateTime(2020, 12, 24);

            Console.WriteLine("");
            Console.WriteLine(bengal.name);
            Console.WriteLine(bengal.favouriteToy);
            Console.WriteLine(bengal.dateOfBirth.ToString("dd.MM.yyyy"));

            if (!inCatShow("Persian"))
            {
                Console.WriteLine("\nPersian cats are not in this cat show");
            }

            Console.ReadLine();

        }
    }
}
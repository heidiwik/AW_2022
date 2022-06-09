using System;

namespace CatExample
{
    class Cat
    {
        string name;
        string favouriteToy;
        DateTime dateOfBirth;

        public void meow()
        {
            Console.WriteLine("Meow!");
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
            bengal.dateOfBirth = new DateTime(2020, 12, 24);

            Console.WriteLine("");
            Console.WriteLine(bengal.name);
            Console.WriteLine(bengal.favouriteToy);
            Console.WriteLine(bengal.dateOfBirth.ToString("dd.MM.yyyy"));

            Console.ReadLine();

        }
    }
}
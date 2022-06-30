using System;
using System.Threading;
using System.Threading.Tasks;

namespace HealthApp
{
    class Program
    {
        private static void PrintFruitData(Fruit fruit)
        {
            Console.WriteLine("");
            Console.WriteLine("  Fruit information:");
            Console.WriteLine($"  Fruit name: {fruit.name}" );
            Console.WriteLine($"  Fruit calories: {fruit.nutritions.calories}" );
            Console.WriteLine($"  Fruit sugar: {fruit.nutritions.sugar}" );
            Console.WriteLine($"  Fruit carbohydrates: {fruit.nutritions.carbohydrates}" );
        }


        private static async Task GetFruitInfo()
        {
            Console.Write("\nGive name of the fruit: ");
            string input = Console.ReadLine();

            Fruit fruit = await FruitApi.GetSingleFruit(input);

            if (fruit == null)
                Console.WriteLine("\n  Fruit not found :(");
            else
                PrintFruitData(fruit);
        }


        static void Main(string[] args)
        {
            GetFruitInfo();
            Console.ReadKey(true);
        }
    }
}

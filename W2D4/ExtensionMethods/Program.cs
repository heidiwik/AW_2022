using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 55;

            if (i.IsGreater(60))
            {
                Console.WriteLine("Found the bigger number");
            } 
            else
            {
                Console.WriteLine("Number was smaller");
            }

            int year = 1990;
            int year2 = 1972;

            if (year.IsGreater(year2))
            {
                Console.WriteLine("year 1 is later");
            }


            if (1337.IsGreater(2))
            {
                Console.WriteLine("1337 is greater than 2");
            }

            int j = 27;
            int added = j.AddByTwo();
            Console.WriteLine(j + " + 2 = " + added);
        }
    }

    public static class IntExtensions
    {
        public static bool IsGreater(this int i, int val)
        {
            bool result = i > val;
            return result;
        }

        public static int AddByTwo(this int i)
        {
            int result = i + 2;
            return result;

            //return i + 2;
        }
    }

}



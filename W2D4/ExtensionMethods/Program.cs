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
        }
    }

    public static class IntExtensions
    {
        public static bool IsGreater(this int i, int val)
        {
            bool result = i > val;
            return result;
        }
    }

}



//Source: https://medium.com/geekculture/asynchronous-and-parallel-programming-in-c-net-1e0f14e1db80

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FindPrimeNumbers
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var primes = GetPrimeNumbers(2, 10000000);
            Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", primes.Count, sw.ElapsedMilliseconds);
        }

        private static List<int> GetPrimeNumbers(int minimum, int maximum)
        {
            List<int> result = new List<int>();
            for (int i = minimum; i <= maximum; i++)
            {
                if (IsPrimeNumber(i))
                {
                    result.Add(i);
                }
            }
            return result;

        }

        static bool IsPrimeNumber(int number)
        {
            if (number % 2 == 0)
            {
                return number == 2;
            }
            else
            {
                var topLimit = (int)Math.Sqrt(number);

                for (int i = 3; i <= topLimit; i += 2)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
        }
    }
}
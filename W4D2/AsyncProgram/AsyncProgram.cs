using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncProgram
{
    class AsyncProgram
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            Task.WaitAll(first(), second(), third());

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");


            async Task first()
            {
                await Task.Delay(3000);
                Console.WriteLine("first finished");
            }

            async Task second()
            {
                await Task.Delay(6000);
                Console.WriteLine("second finished");
            }

            async Task third()
            {
                await Task.Delay(1000);
                Console.WriteLine("third finished");
            }
        }
    }
}

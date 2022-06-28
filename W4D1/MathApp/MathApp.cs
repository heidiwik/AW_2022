using System;
using MathLibrary;

namespace MathApp
{
    class MathApp
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();

            float tulos = mathHelper.Substract(1340, 3);

            Console.WriteLine("Tulos on: " + tulos);

        }
    }
}

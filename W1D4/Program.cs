using System;

namespace W1D4
{
    class Program
    {
		static void Main(string[] args)
		{
			Hello();

			int a = 70;
			int b = 12;
			int maxNumber = FindMaxNum(a, b);
			Console.WriteLine(maxNumber + " is the biggest number");
		}

		static void Hello()
		{
			Console.WriteLine("Hello from a method!");
		}


		static int FindMaxNum(int num1, int num2)
		{
			if (num1 > num2)
				return num1;
			else
				return num2;
		}


	}
}

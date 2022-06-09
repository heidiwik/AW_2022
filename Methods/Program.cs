using System;
using System.IO;

namespace W1D4
{
    class Program
    {
		static void Main(string[] args)
		{
			int a = 70;
			int b = 12;
			string maxNumber = FindMaxNum(a, 33);

			string name = "Heidi";
			int day = 4;
			SayHello(name, day);

			Console.WriteLine(maxNumber);


			string anotherMaxNumber = FindMaxNum(1, 0);

			Console.WriteLine(anotherMaxNumber);
		}

		static void Hello()
		{
			Console.WriteLine("Hello from a method!");
		}

		static void SayHello(string username, int daynumber)
		{
			Hello();
			Console.WriteLine("Hello " + username);
			Console.WriteLine("Today is day " + daynumber + " of the course");

			File.WriteAllText("Userlist.txt", username);
		}

		static public string FindMaxNum(int num1, int num2)
		{
			string result;

			if (num1 > num2)
			{
				result = num1 + " on suurempi numero";
			}
			else
			{
				result = num2 + " on suurempi numero";
			}

			return result;
		}


	}
}

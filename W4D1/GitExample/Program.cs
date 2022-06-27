using System;

namespace Welcome
{
	class Welcome
    {
		// Main Method
		public static void Main()
		{
			User newUser = new User("Ernesti", 25);

			Console.WriteLine("Welcome to week 4 " + newUser.name);
		}
	}

	public class User
	{
		// data members
		int id;
		public string name;
		public int age;

		// constructor
		public User(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

	}
}
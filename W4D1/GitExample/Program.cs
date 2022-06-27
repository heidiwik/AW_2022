using System;

namespace User
{
	class User
	{
		// data members
		int id;
		string name;
		int age;

		// constructor
		User(string name)
		{
			this.name = name;
		}

		// Main Method
		public static void Main()
		{
			User newUser = new User("Ernesti");

			Console.WriteLine("Welcome to week 4 " + newUser.name);
		}
	}
}
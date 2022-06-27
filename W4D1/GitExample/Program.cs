using System;

namespace User
{
	class User
	{
		// data members
		int id;
		string name;
		string city;

		// constructor
		User(string name, string city)
		{
			this.name = name;
			this.city = city;
		}

		// Main Method
		public static void Main()
		{
			User newUser = new User("Ernesti", "Turku");

			Console.WriteLine("Welcome to week 4 " + newUser.name);
		}
	}
}
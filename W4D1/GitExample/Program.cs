using System;

namespace Welcome
{
	class Welcome
    {
		// Main Method
		public static void Main()
		{
			User newUser = new User("Ernesti", "Turku");

			Console.WriteLine("Welcome to week 4 " + newUser.name);
		}
	}

	public class User
	{
		// data members
		int id;
		public string name;
		public string city;

		// constructor
		public User(string name, string city)
		{
			this.name = name;
			this.city = city;
		}

	}
}
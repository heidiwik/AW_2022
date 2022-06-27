using System;

namespace Welcome
{
	class Welcome
    {
		public static void Main()
		{
			User newUser = new User("Ernesti");

			Console.WriteLine("Welcome to week 4 " + newUser.firstName);
		}
	}

	public class User
	{
		int id;
		public string firstName;

		public User(string name)
		{
			this.firstName = name;
		}

	}
}
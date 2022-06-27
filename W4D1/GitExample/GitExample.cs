using System;

namespace Welcome
{
	public class User
	{
		int id;
		string firstName;
		int age;

		// constructor
		User(string name, int age)
		{
			this.firstName = name;
			this.age = age;
		}

		public static void Main()
		{

			User newUser = new User("Pertti", 72);

			Console.WriteLine("Welcome to course week 4 " + newUser.firstName);
		}

	}
}
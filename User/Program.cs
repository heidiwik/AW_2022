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
		User(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		// Main Method
		public static void Main()
		{
			User newUser = new User("Ernesti", 21);

			Console.WriteLine(newUser.name);
			Console.WriteLine(newUser.age);
		}
	}
}
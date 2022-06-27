using System;

namespace Welcome
{
	class Welcome
    {
		public static void Main()
		{

			User newUser = new User("Terttu", "dog");

			Console.WriteLine("Yay you made it to week 4 " + newUser.name + "!");
			Console.WriteLine("Say hi to your " + newUser.pet);
		}
	}

	public class User
	{
		int id;
		public string name;
		public string pet;

		// constructor
		public User(string name, string pet)
		{
			this.name = name;
			this.pet = pet;

		}

	}
}
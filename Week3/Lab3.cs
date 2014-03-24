using System;

namespace CountString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = "Dahye Kim"; 
			string greeting = "Hello! ";
			string result = greeting + name;
			Console.WriteLine ("{0} - the number of characters: {1}", result, result.Length);


		}
	}
}

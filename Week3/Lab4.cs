using System;

namespace calculator_sum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string n1 = Console.ReadLine ();
			string n2 = Console.ReadLine ();
			int num1 = int.Parse (n1);
			int num2 = int.Parse (n2);
			Console.WriteLine ("The first number: {0}, The second number: {1}, The sum of the two integers is {2}", num1, num2, num1 + num2);
		}
	}
}


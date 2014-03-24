using System;

namespace average
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1 = 100;
			int num2 = 200;
			int num3 = 300;
			int num4 = 400;

			int avrg = (num1 + num2 + num3 + num4) / 4;
			Console.WriteLine ("{0}, {1}, {2}, {3}, and the average is {4}.", num1, num2, num3, num4, avrg);
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataFizzBuzz
{
	public class ServiceFizzBuzz
	{
		public const string Fizz = "Fizz";
		public const string Buzz = "Buzz";
		public const string FizzBuzz = "FizzBuzz";

		public static string Print(int number)
		{
			if (number % 3 == 0 && number % 5 == 0)
				return FizzBuzz;
			if (number % 3 == 0)
				return Fizz;
			if (number % 5 == 0)
				return Buzz;

			return number.ToString();
		}
	}
}

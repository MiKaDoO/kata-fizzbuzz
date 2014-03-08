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
			if (IsBuzz(number) && IsFizz(number))
				return FizzBuzz;
			if (IsFizz(number))
				return Fizz;
			if (IsBuzz(number))
				return Buzz;

			return number.ToString();
		}

		private static bool IsFizz(int number)
		{
			return number % 3 == 0;
		}

		private static bool IsBuzz(int number)
		{
			return number % 5 == 0;
		}
	}
}

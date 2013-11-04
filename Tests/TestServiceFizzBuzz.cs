using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KataFizzBuzz;

namespace Tests
{
	[TestFixture]
	class TestServiceFizzBuzz
	{
		[TestCase(1)]
		public void Test_Print_Number(int number)
		{
			string res = ServiceFizzBuzz.Print(number);

			Assert.AreEqual(number.ToString(), res);
		}

		[TestCase(3)]
		[TestCase(6)]
		[TestCase(9)]
		[TestCase(12)]
		[TestCase(18)]
		[TestCase(21)]
		[TestCase(24)]
		[TestCase(27)]
		[TestCase(33)]
		[TestCase(36)]
		[TestCase(39)]
		[TestCase(42)]
		[TestCase(48)]
		[TestCase(51)]
		[TestCase(54)]
		[TestCase(57)]
		[TestCase(63)]
		[TestCase(66)]
		[TestCase(69)]
		[TestCase(72)]
		[TestCase(78)]
		[TestCase(81)]
		[TestCase(84)]
		[TestCase(87)]
		[TestCase(93)]
		[TestCase(96)]
		[TestCase(99)]
		public void Test_Print_Fizz_If_Number_Is_Multiple_Of_Three(int number)
		{
			string res = ServiceFizzBuzz.Print(number);

			Assert.AreEqual(ServiceFizzBuzz.Fizz, res);
		}

		[Test]
		public void Test_Const_Fizz_Is_Fizz()
		{
			Assert.AreEqual("Fizz", ServiceFizzBuzz.Fizz);
		}

		[TestCase(5)]
		[TestCase(10)]
		[TestCase(20)]
		[TestCase(25)]
		[TestCase(35)]
		[TestCase(40)]
		[TestCase(50)]
		[TestCase(55)]
		[TestCase(65)]
		[TestCase(70)]
		[TestCase(80)]
		[TestCase(85)]
		[TestCase(95)]
		[TestCase(100)]
		public void Test_Print_Buzz_If_Number_Is_Multiple_Of_Five(int number)
		{
			string res = ServiceFizzBuzz.Print(number);

			Assert.AreEqual(ServiceFizzBuzz.Buzz, res);
		}

		[Test]
		public void Test_Const_Buzz_Is_Buzz()
		{
			Assert.AreEqual("Buzz", ServiceFizzBuzz.Buzz);
		}

		[TestCase(15)]
		[TestCase(30)]
		[TestCase(45)]
		[TestCase(60)]
		[TestCase(75)]
		[TestCase(90)]
		public void Test_Print_FizzBuzz_If_Number_Is_Multiple_Of_Five_And_Three(int number)
		{
			string res = ServiceFizzBuzz.Print(number);

			Assert.AreEqual("FizzBuzz", res);
		}

		[Test]
		public void Test_Const_FizzBuzz_Is_FizzBuzz()
		{
			Assert.AreEqual("FizzBuzz", ServiceFizzBuzz.FizzBuzz);
		}
	}
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTestsForCalculator.Tests
{
	[TestFixture]
	class CalculatorTests
	{

		[Test]
		public void MultiplicationMustReturnNotNullValue()
		{
			var calc = new Calculator();

			Assert.AreEqual(50, calc.Miltiplication(10, 5));
		}

		[Test]
		public void AddAlwaysReturnsExpectedValue()
		{
			var calculatorTest = new Calculator();
			Assert.That(calculatorTest.Additional(50, 100), Is.EqualTo(150));
		}

		[Test]
		public void SubtractionAlwaysReturnsExpectedValue()
		{
			var calculatorTest = new Calculator();
			Assert.That(calculatorTest.Subtraction(30, 20), Is.EqualTo(10));
		}

		[Test]
		public void DivisionAlwaysReturnsExpectedValue()
		{
			var calculatorTest = new Calculator();
			Assert.That(calculatorTest.Division(100, 50), Is.EqualTo(2));
		}

		[Test]
		public void DivisionThrowsException()
		{
			var calculatorTest = new Calculator();
			Assert.Throws<DivideByZeroException>(() => calculatorTest.Division(100, 0));
		}
	}
}

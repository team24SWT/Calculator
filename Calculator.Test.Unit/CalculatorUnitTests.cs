using NUnit.Framework;
using System;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private LE_00.Calculator uut;

        [SetUp]
        public void Setup()
        {
             uut = new LE_00.Calculator();
        }

        [TestCase(2, 4, 6), Description("Sætte to positive tal sammen - to parameter")]
        [TestCase(20, 40, 60)]
        [TestCase(8, 4.5, 12.5)]
        public void TestAddPositive(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }
     
        [TestCase(-5, 10, -15), Description("Trække to tilfældige tal fra hinanden - to parameter")]
        [TestCase(5, -1, 6)]
        [TestCase(5, -10, 15)]  
        public void TestSubstractRandom(double a, double b, double result)
        {
            Assert.That(uut.Substract(a, b), Is.EqualTo(result));
        }
       
        [TestCase(2, 3, 8), Description("Positivt tal opløftet i et positivt tal - to parameter")]
        [TestCase(3, 3, 27)]
        [TestCase(10, 4, 10000)]
        public void TestPowerMultiple(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 7, 14), Description("Gange to positive tal - to parameter")]
        [TestCase(8, 9, 72)]
        [TestCase(13, 3, 39)]
        public void TestMultiplyPositive(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2,-5,-10), Description("Gange et positivt tal med et negativt tal - to parameter")]
        [TestCase(3, -4, -12)]
        [TestCase(7, -2, -14)]
        public void TestMultiplyNegative(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2.5, 0), Description("Division med nul - to parameter")]
        [TestCase(234, 0)]
        [TestCase(14564, 0)]
        public void TestDivideNull(double a, double b)   
        {
            Assert.That(() => uut.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(45, 9, 5), Description("Division med to tal - to parameter")]
        [TestCase(144, 12, 12)]
        [TestCase(333, 111, 3)]
        public void DivideToParameter(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test, Description("Tester at accumulator er nul uden brug")]
        public void TestAccumulatorIsZero()
        {
            Assert.That(uut.Accumulator, Is.Zero);
        }

        [TestCase(5, 5), Description("Sætte to positive tal sammen - en parameter")]
        [TestCase(20, 20)]
        [TestCase(532, 532)]
        public void TestAdd(double a, double result)
        {
            uut.Add(a);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(13, -13), Description("Trække to tilfældige tal fra hinanden - en parameter")]
        [TestCase(-7.5, 7.5)]
        [TestCase(3645, -3645)]
        public void TestSubstract(double a, double result)
        {
            uut.Substract(a);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(5, 5, 3125), Description("Positivt tal opløftet i et positivt tal - en parameter")]
        [TestCase(20, 2, 400)]
        [TestCase(15, 0, 1)]
        public void TestPower(double a, double b, double result)
        {
            uut.Add(a);
            uut.Power(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 2, 20), Description("Gange et positivt tal med et negativt tal - en parameter")]
        [TestCase(30, 4, 120)]
        [TestCase(10, 0, 0)]
        public void TestMultiply(double a, double b, double result)
        {          
            uut.Add(a);
            uut.Multiply(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 2, 5), Description("Division med to tal - en parameter")]
        [TestCase(30, 4, 7.5)]
        [TestCase(112, 7, 16)]
        public void TestDivide(double a, double b, double result)
        {
            uut.Add(a);
            uut.Divide(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 0), Description("Division med nul - en parameter")]
        [TestCase(30, 0)]
        [TestCase(112, 0)]
        public void TestSingleDivideWithZero(double a, double b)
        {
            uut.Add(a);
            Assert.That(() => uut.Divide(b), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(100, 0), Description("Test af funktion til at clear accumulator")]
        [TestCase(100000, 0)]
        [TestCase(7, 0)]
        public void ClearTest(double a, double result)
        {
            uut.Add(a);
            uut.Clear();
            Assert.AreEqual(result, uut.Accumulator);
        }
    }
}
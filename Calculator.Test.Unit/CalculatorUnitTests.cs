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

        [TestCase(2, 4, 6)]
        [TestCase(20, 40, 60)]
        [TestCase(8, 4.5, 12.5)]

        public void Add_AddToPositiveTal_og_Get_Resultat(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }
     
        [TestCase(-5, 10, -15)]
        [TestCase(5, -1, 6)]
        [TestCase(5, -10, 15)]  
        public void Substract_PositiveTal_Fra_NegativeTal(double a, double b, double result)
        {
            Assert.That(uut.Substract(a, b), Is.EqualTo(result));
        }
       
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(10, 4, 10000)]
        public void Exp_EtTal_Oplyfte_I_AndetTal(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 7, 14)]
        [TestCase(8, 9, 72)]
        [TestCase(13, 3, 39)]
        public void GangeToPositiveTal(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2,-5,-10)]
        [TestCase(3, -4, -12)]
        [TestCase(7, -2, -14)]
        public void GangePositivTalMedNegativTal(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2.5, 0)]
        [TestCase(234, 0)]
        [TestCase(14564, 0)]
        public void DivideMedNull(double a, double b)   
        {
            Assert.That(() => uut.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(45, 9, 5)]
        [TestCase(144, 12, 12)]
        [TestCase(333, 111, 3)]
        public void DivideToParameter(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void TestAccumulatorIsZero()
        {
            Assert.That(uut.Accumulator, Is.Zero);
        }

        [TestCase(5, 5)]
        [TestCase(20, 20)]
        [TestCase(532, 532)]
        public void TestAdd(double a, double result)
        {
            uut.Add(a);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(13, -13)]
        [TestCase(-7.5, 7.5)]
        [TestCase(3645, -3645)]
        public void TestSubstract(double a, double result)
        {
            uut.Substract(a);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(5, 5, 3125)]
        [TestCase(20, 2, 400)]
        [TestCase(15, 0, 1)]
        public void TestPower(double a, double b, double result)
        {
            uut.Add(a);
            uut.Power(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 2, 20)]
        [TestCase(30, 4, 120)]
        [TestCase(10, 0, 0)]
        public void TestMultiply(double a, double b, double result)
        {          
            uut.Add(a);
            uut.Multiply(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 2, 5)]
        [TestCase(30, 4, 7.5)]
        [TestCase(112, 7, 16)]
        public void TestDivide(double a, double b, double result)
        {
            uut.Add(a);
            uut.Divide(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 0)]
        [TestCase(30, 0)]
        [TestCase(112, 0)]
        public void TestSingleDivideWithZero(double a, double b)
        {
            uut.Add(a);
            Assert.That(() => uut.Divide(b), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(100, 0)]
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
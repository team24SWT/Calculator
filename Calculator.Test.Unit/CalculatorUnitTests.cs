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
            // Arange
            //var uut = new LE_00.Calculator();
            // Act
            // Asert
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }
     
        [TestCase(-5, 10, -15)]
        [TestCase(5, -1, 6)]
        [TestCase(5, -10, 15)]  
        public void Substract_PositiveTal_Fra_NegativeTal(double a, double b, double result)
        {
            Assert.That(uut.Substract(a, b), Is.EqualTo(result));
        }
       
        [TestCase(2,3,8)]
        public void Exp_EtTal_Oplyfte_I_AndetTal(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }
        [TestCase(2, 7, 14)]
        

        public void GangeTo_Positive_Tal(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

    }
}
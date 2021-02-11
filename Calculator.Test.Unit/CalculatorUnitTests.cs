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
        [TestCase(2,-5,-10)]
        public void GangePositivTalmedNegativTal(double a, double b, double result )
        {
            Assert.That(uut.Multiply(a,b), Is.EqualTo(result));
        }

        [TestCase(2.5,0,0)]
        
        public void DevideMedNull(decimal a, decimal b, decimal result)
        {
            var exp = Assert.Catch<DivideByZeroException>(() => uut.Divide(a, b));
            StringAssert.Contains("Fejl", exp.Message);
            
        }

        [TestCase(45,9, 5)]
        [TestCase(144,12,12)]
        public void DevideToTal(decimal a, decimal b, decimal result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }
            
    }
}
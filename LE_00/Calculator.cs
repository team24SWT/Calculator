using System;
using System.Collections.Generic;
using System.Text;

namespace LE_00
{
   public class Calculator
    {

        
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x,double exp)
        {
            return Math.Pow(x, exp);
        }

        public decimal Divide(decimal a, decimal b)
        {
            try
            {
                return a / b;
            }
            catch(Exception e)
            {
                throw new DivideByZeroException("Fejl");
            }




        }

        
    }

}

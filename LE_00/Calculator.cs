using System;
using System.Collections.Generic;
using System.Text;

namespace LE_00
{
    public class Calculator
    {


        public double Add(double a, double b)
        {

            Accumulator = a + b;
            return Accumulator;
        }
        public double Substract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

       
        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }
        public double Substract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Power(double a)
        {
            Accumulator = Math.Pow(Accumulator, a);
            return Accumulator;
        }

        public decimal Divide(decimal a, decimal b)
        {
            try
            {
                Accumulator = (double)a / (double)b;
                return (decimal)Accumulator;
            }
            catch (Exception)
            {
                throw new DivideByZeroException("Fejl");
            }

        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }


    }

}

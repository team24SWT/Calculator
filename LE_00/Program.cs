using System;

namespace LE_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Beregning1 = new Calculator();

            Console.WriteLine($"Result is{Beregning1.Add(5, 6)}");
            Console.WriteLine($"Result is{Beregning1.Power(3, 5)}");
            Console.WriteLine("Ole is the President"); 
        }
    }
}

using System;

namespace Ch04
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOfA = 10, valueOfB = 20;
            Calculator calculator = new Calculator();
            Console.WriteLine("The sum using instance method \t{0} \nand using static method \t{1}",
                calculator.Add(valueOfA, valueOfB),
                CalculatorAsStatic.Add(valueOfA, valueOfB));
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public static class CalculatorAsStatic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
//using System;

//namespace Ch04
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            Console.WriteLine(calculator.Sub(10, 5));
//        }
//    }
//    public static class Ch04_ExtensionMethods  		    /* A Static class defined */
//    {
//        public static int Sub(this Calculator calculator, int a, int b)
//        {
//            return a > b ? a - b : b - a;
//        }
//    }

//    public class Calculator
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//    }
//}

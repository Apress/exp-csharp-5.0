//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator calculator = new ScientificCalculator();
//            Console.WriteLine(calculator.Add(10, 10));  	/* 120 */
//        }
//    }

//    /* Interface declaration */
//    interface IAddition { int Add(int a, int b); }

//    /* Interface implementation */
//    public class Calculator : IAddition
//    {
//        public virtual int Add(int a, int b) { return a + b; }
//    }

//    public class ScientificCalculator : Calculator
//    {
//        public override int Add(int a, int b) { return 100 + a + b; }
//    }
//}

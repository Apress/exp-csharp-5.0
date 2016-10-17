//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StandardCalculator sc = new StandardCalculator();
//            Console.WriteLine(sc.Add(10, 10));     /* 20 */
//            Console.WriteLine(sc.Sub(10, 10));     /*  0 */
//        }
//    }

//    public abstract class Calculator
//    {
//        public abstract int Add(int a, int b);
//        public int Sub(int a, int b) { return b - a; }
//    }

//    public class StandardCalculator : Calculator
//    {
//        public override int Add(int a, int b) { return a + b; }
//    }
//}

//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            Console.WriteLine(calculator.Add(10, 10));      /* 20 */
//            Console.WriteLine(calculator.Sub(10, 10));      /* 0 */
//            Console.WriteLine(calculator.Mul(9, 7));        /* 63 */
//        }
//    }

//    /* interface definition*/
//    interface IAddition { int Add(int a, int b);} /* Interface declaration */
//    interface IExAddition { int Add(int a, int b);} /* Interface declaration */
//    interface ISubtraction { int Sub(int a, int b);}/* Interface declaration */
//    interface IMultiplication : IAddition { int Mul(int a, int b);  }  	/* Extending Interface declaration */

//    /* interface implementation*/
//    public class Calculator :
//        IAddition,
//        ISubtraction,
//        IMultiplication,
//        IExAddition                                          		/* Multiple interface implementation */
//    {
//        public int Add(int a, int b) { return a + b; }

//        int IExAddition.Add(int a, int b)                                	/* Explicit interface implementation */
//        { return 100 + a + b; }

//        public int Sub(int a, int b) { return a > b ? a - b : b - a; }

//        public int Mul(int a, int b)
//        {
//            var result = 0;
//            for (int i = 0; i < a; ++i)
//                result += Add(0, b);
//            return result;
//        }
//    }
//}

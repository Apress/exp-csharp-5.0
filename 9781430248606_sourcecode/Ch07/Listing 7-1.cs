//using System;

//namespace Ch07
//{
//    class Program
//    {
//        /* declare a delegate type. */
//        delegate int DelegateOfTheCalculator(int a, int b);

//        static void Main(string[] args)
//        {
//            DelegateHandler();
//        }

//        static void DelegateHandler()
//        {
//            StandardCalculator standardCalculator = new StandardCalculator();

//            DelegateOfTheCalculator delegateOfTheCalculator =
//                                        new DelegateOfTheCalculator(standardCalculator.Add);
//            delegateOfTheCalculator += standardCalculator.Sub;
//            delegateOfTheCalculator -= standardCalculator.Sub;

//            /* Execute the Add method */
//            Console.WriteLine("Sum of a and b is:{0}", delegateOfTheCalculator(10, 10));
//        }
//    }

//    public class StandardCalculator
//    {
//        public int Add(int a, int b) { return a + b; }
//        public int Sub(int a, int b) { return a > b ? a - b : 0; }
//        public int Mul(int a, int b) { return a * b; }
//    }
//}

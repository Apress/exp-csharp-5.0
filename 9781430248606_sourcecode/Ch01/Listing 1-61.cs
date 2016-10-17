//using System;
//namespace Ch01
//{
//    /* A delegate which will encapsulate a method which accept two parameter 
//     * and return int */
//    delegate int BinaryOperation(int x, int y);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Calculate(Add, new Tuple<int, int>(10, 10));    	/* 20  */
//            Calculate(Sub, new Tuple<int, int>(10, 10));    	/*  0  */
//            Calculate(Sub, new Tuple<int, int>(1, 10));     	/*  9  */
//        }

//        static void Calculate(
//                    BinaryOperation binaryOperation, Tuple<int, int> data)
//        {
//            Console.WriteLine(binaryOperation(data.Item1, data.Item2));
//        }

//        static int Add(int x, int y)
//        {
//            return x + y;
//        }

//        static int Sub(int x, int y)
//        {
//            return x > y ? x - y : y - x;
//        }
//    }
//}

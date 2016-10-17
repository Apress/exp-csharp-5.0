//using System;

//namespace Ch04
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int valueOfA = 10,
//                valueOfB = 20,
//                increment = 2;   			/* Used as the external or captured variable 
//                         * for the anonymous method */
//            Calculator calculator = new Calculator();

//            Console.WriteLine("The sum is \t:{0}", calculator.Add
//                (delegate(int a, int b) 			/* Anonymous method declaration */
//                {
//                    return a + b + increment;			/* increment is the outer variable */
//                }, valueOfA, valueOfB));
//        }
//    }

//    public class Calculator
//    {
//        public delegate int Adder(int a, int b);

//        public int Add(Adder adder, int a, int b)
//        {
//            return adder(a, b);
//        }
//    }
//}

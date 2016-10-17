//using System;
//using System.Collections;

//namespace Ch09
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int currentExponent = 0;
//            int iterationPhase = 0;
//            Console.WriteLine("{0,10}\t{1,10}\t{2,10}",
//                    "Iteration Phase", "Power", "Next Power will be");
//            foreach (int i in Power(2, 4))
//            {
//                currentExponent = i;
//                Console.Write("{0,9}\t{1,9}",
//                    ++iterationPhase, currentExponent);
//            }
//        }

//        public static IEnumerable Power(int number, int exponent)
//        {
//            int counter = 0;
//            int result = 1;
//            while (counter++ < exponent)
//            {
//                result = result * number;
//                yield return result;
//                Console.WriteLine("\t{0,9}x{1}\t\u25BC", result, number);
//            }
//        }
//    }
//}

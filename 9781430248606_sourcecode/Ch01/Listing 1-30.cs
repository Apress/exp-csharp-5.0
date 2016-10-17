//using System;
//using System.Collections;

//namespace Ch01
//{
//    class Program
//    {
//        static void Main()
//        {
//            foreach (int i in GeneratePower(2, 4))
//            {
//                Console.Write("{0} ", i);
//            }
//        }

//        public static IEnumerable GeneratePower(int initialValue, int range)
//        {
//            int result = 1;
//            for (int counter = 0; counter < range; ++counter)
//            {
//                result = result * initialValue;
//                yield return result;
//            }
//        }
//    }
//}

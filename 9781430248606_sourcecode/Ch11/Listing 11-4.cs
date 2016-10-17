//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace Ch11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = new List<int>()
//            {
//                0,1, 2, 3
//            };
//            numbers.InsertRange(3, new List<int>() { 22, 33, 77 });
//            ShowResult(numbers);
//        }

//        public static void ShowResult(IEnumerable aList)
//        {
//            foreach (var item in aList)
//                Console.Write("{0}\t", item);
//            Console.WriteLine();
//        }
//    }
//}

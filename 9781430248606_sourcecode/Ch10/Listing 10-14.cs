//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace Ch10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<string> listOfNumbers = new List<string>() 
//            { 
//                "One,", "Two,", "Three." 
//            };
//            Console.WriteLine("{0}", ConcateUsingConcate(listOfNumbers));
//        }

//        static string ConcateUsingConcate(IEnumerable<string> enumerable)
//        {
//            return string.Concat<string>(enumerable);
//        }
//    }
//}

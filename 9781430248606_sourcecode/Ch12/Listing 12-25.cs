//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<int> firstNumbers = new List<int>()
//            {
//                1,2,3,4,5,6,7
//            };
//            IList<int> secondNumbers = new List<int>()
//            {
//                1,2,3
//            };

//            var result = firstNumbers.Except(secondNumbers).ToList();
//            result.ForEach(x => Console.Write(string.Format("{0}\t", x)));
//        }
//    }
//}

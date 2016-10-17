//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<int> firstNumbers = new List<int>();

//            IList<int> secondNumbers = new List<int>()
//            {
//                1,2,3,4,5,6,7
//            };

//            var lastItemOfFirstList = firstNumbers.LastOrDefault();
//            var lastItemIfFirstListBasedOnConditions =
//                firstNumbers.LastOrDefault(item => item > 3);

//            var lastItemOfSecondList = secondNumbers.LastOrDefault();
//            var lastItemOfSecondListBasedOnConditions =
//                secondNumbers.LastOrDefault(item => item > 3);

//            Console.Write(string.Format("{0}\t{1}\t{2}\t{3}",
//                lastItemOfFirstList,
//                lastItemIfFirstListBasedOnConditions,
//                lastItemOfSecondList,
//                lastItemOfSecondListBasedOnConditions
//                ));
//        }
//    }
//}

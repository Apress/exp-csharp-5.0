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
//            IList<int> listOne = new List<int>() 
//            { 
//                1,2,3,4,5,6
//            };

//            IList<int> listTwo = new List<int>() 
//            { 
//                6,7,8,9,10
//            };

//            var result = listOne.Concat(listTwo).ToList();
//            result.ForEach(x => Console.Write(string.Format("{0}\t", x)));
//        }
//    }
//}

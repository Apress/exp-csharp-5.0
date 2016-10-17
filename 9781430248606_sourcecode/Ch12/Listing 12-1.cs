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
//            IList<string> numbers = new List<string>() 
//            { 
//                "One", "Two", "Three", "Four", "Five", "Six", "Seven" 
//            };

//            var numbersLengthThree =
//                numbers.Where(x => x.Length == 3).Select(x => x).ToList();

//            numbersLengthThree.ForEach(x => Console.WriteLine(x));
//        }
//    }
//}

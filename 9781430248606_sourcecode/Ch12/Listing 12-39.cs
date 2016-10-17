//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            List<string> numbers = new List<string>() 
//            { 
//                "One", "Two", "Three", "Four" 
//            };

//            var result = numbers.Aggregate(
//                (aggregatedValue, nextItem) =>
//                nextItem + aggregatedValue);

//            Console.WriteLine("Aggregated value : {0}", result);
//        }
//    }
//}

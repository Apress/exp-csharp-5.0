//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> items = new List<string>() 
//            { 
//                "One", "Two", "Three", "Four" 
//            };
//            var result = items.Aggregate(
//                /* Zero as seed, to use the initial aggregate value */
//                    "Zero",
//                    (temporaryAggregatedValue, nextItem) =>
//                    {
//                        Console.WriteLine(temporaryAggregatedValue);
//                        return nextItem + temporaryAggregatedValue;
//                    },
//                    aggregatedResult =>
//                    string.Format("Final result : {0}",
//                                  aggregatedResult.ToUpper())
//                );
//            Console.WriteLine(result);
//        }
//    }
//}

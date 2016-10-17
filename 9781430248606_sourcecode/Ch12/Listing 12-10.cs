//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<int> series = new List<int>()
//           {
//               1,2,3,4,5,6,7
//           };
//            Console.WriteLine("When the condition is true");
//            series.TakeWhile(number => number < 3)
//                .ToList()
//                .ForEach(number => Console.Write(string.Format("{0}\t",
//                                                                 number)));

//            Console.WriteLine("\nOn first false return iteration will stop ");
//            series.TakeWhile(number => number > 3)
//                .ToList()
//                .ForEach(number => Console.Write(string.Format("{0}\t",
//                                                                 number)));
//        }
//    }
//}

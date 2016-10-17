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
//            IList<string> listStringWithoutItem = new List<string>();
//            IList<string> listStringWithItem = new List<string>() { "One" };
//            IList<int> listInt = new List<int>();
//            IList<char> listChar = new List<char>();
//            IList<long> listLong = new List<long>();
//            IList<double> listDouble = new List<double>();

//            Console.WriteLine("string   : {0}",
//                              listStringWithoutItem.SingleOrDefault());
//            Console.WriteLine("string   : {0}",
//                              listStringWithItem.SingleOrDefault());
//            Console.WriteLine("int      : {0}", listInt.SingleOrDefault());
//            Console.WriteLine("char     : {0}", listChar.SingleOrDefault());
//            Console.WriteLine("long     : {0}", listLong.SingleOrDefault());
//            Console.WriteLine("double   : {0}", listDouble.SingleOrDefault());
//        }
//    }
//}

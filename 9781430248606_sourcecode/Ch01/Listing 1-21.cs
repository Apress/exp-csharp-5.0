//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] planets = { "Jupiter", "\n", "Pallas" };
//            Console.WriteLine("{0}", ConcatStrings(planets));
//        }

//        static string ConcatStrings(params string[] items)
//        {
//            string result = default(string);
//            foreach (string item in items)
//            { result = string.Concat(result, item); }
//            return result;
//        }
//    }
//}

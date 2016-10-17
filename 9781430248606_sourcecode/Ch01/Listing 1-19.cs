//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 100;          /* Needs to initialize x */
//            Console.WriteLine(x); /* 100 */
//            Increment(ref x);     /* pass the location (0x052de8b4) of the x */
//            Console.WriteLine(x); /* 101 */
//        }
//        static void Increment(ref int a) /* a pointing to the same memory  
//                                          * location as x (0x052de8b4) 
//                                          * of Main method */
//        { ++a; }
//    }
//}

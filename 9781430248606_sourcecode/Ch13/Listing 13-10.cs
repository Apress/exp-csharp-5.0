//using System;

//namespace Ch13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                ExampleOfRethrow();
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine(exception.StackTrace);
//            }
//        }

//        static void ExampleOfRethrow()
//        {
//            try
//            {
//                int a = 10, b = 0;
//                var result = a / b;
//            }
//            catch
//            {
//                throw;
//            }
//        }
//    }
//}

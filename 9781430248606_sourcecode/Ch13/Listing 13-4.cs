///* First version of the Exception handling */

//using System;

//namespace Ch13
//{
//    class MainClass
//    {
//        static void Main(string[] args)
//        {
//            Division div = new Division();
//            div.Divide(100, 0);
//        }
//    }
//    public class Division
//    {
//        public int Divide(int a,
//            int b)
//        {
//            try
//            {
//                return a / b;
//            }
//            /* Exception is handled in here by catching all the exception. */
//            catch (Exception exception)
//            {
//                Console.WriteLine(
//                    exception.StackTrace);
//                return -1;
//            }
//        }
//    }
//}

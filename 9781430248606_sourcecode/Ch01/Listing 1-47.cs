//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main()
//        {
//            AClass anObjectOfAClass = new AClass();
//            anObjectOfAClass.Method1();
//            Console.ReadLine();
//        }
//    }
//    public class AClass
//    {
//        public void Method1()
//        {
//            Console.WriteLine("Method 1");
//            this.Method2();        /* this keyword used to invoke methodd2 */
//        }
//        private void Method2()
//        {
//            Console.WriteLine("Method 2");
//            Method3();             /* this keyword can not be used to 
//                                    * static methodd3 */
//        }
//        public static void Method3()
//        {
//            Console.WriteLine("Method 2");
//        }
//    }
//}

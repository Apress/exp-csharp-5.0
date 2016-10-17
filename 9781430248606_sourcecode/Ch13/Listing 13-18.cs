//using System;

//namespace Ch13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Division div = new Division();
//            div.Divide(100, 0);
//            Console.ReadLine();
//        }

//        public class Division
//        {
//            public int Divide(int a, int b)
//            {
//                try
//                {
//                    return a / b;
//                }

//                catch (IndexOutOfRangeException indexOutOfRangeException)
//                {
//                    Console.WriteLine("IndexOutOfRangeException");
//                }
//                catch (ArgumentException argumentException)
//                {
//                    Console.WriteLine("ArgumentException");
//                }
//                catch (DivideByZeroException divideByZeroException)
//                {
//                    Console.WriteLine("{0}\n{1}",
//                        "DivideByZeroException",
//                        "This handler block will execute.");
//                }
//                catch (Exception exception)
//                {
//                    Console.WriteLine("{0}",
//                        "It will execute when there is no best matched found.");
//                }
//                return -1;
//            }
//        }
//    }
//}

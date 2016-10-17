//using System;

//namespace Ch01
//{
//    class Program
//    {
//        public static int Y = StaticClass.X + 1;     /* StaticClass.X= 1 */
//        static Program() { }
//        static void Main()
//        {
//            Console.WriteLine("X = {0}, Y = {1}", StaticClass.X, Program.Y);
//        }
//    }

//    class StaticClass
//    {
//        public static int X;                         	/*0*/
//        static StaticClass()
//        {
//            X = Program.Y + 1;                       /* Program.Y = 0 */
//        }
//    }
//}

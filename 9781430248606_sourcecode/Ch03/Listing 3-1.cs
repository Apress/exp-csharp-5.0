//using System;

//namespace Ch03
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BuiltInValuePassingAsValue temp = new BuiltInValuePassingAsValue();
//            temp.MethodA();
//        }
//    }

//    public class BuiltInValuePassingAsValue
//    {
//        public BuiltInValuePassingAsValue()
//        { Console.WriteLine("Built in value type passing as value"); }

//        public void MethodA()
//        {
//            int a = 10, b = 10;
//            MethodB(a, b);
//            Console.WriteLine("Method A: {0},{1}", a, b);
//        }

//        public void MethodB(int a, int b)
//        { Console.WriteLine("Method B: {0},{1}", a, b); }
//    }
//}

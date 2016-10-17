//using System;

//namespace Ch03
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BuiltInValuePassingAsRef temp = new BuiltInValuePassingAsRef();
//            temp.MethodA();
//        }
//    }

//    public class BuiltInValuePassingAsRef
//    {
//        public BuiltInValuePassingAsRef()
//        {
//            Console.WriteLine("Built in value type passing as ref");
//        }

//        public void MethodA()
//        {
//            int a = 10, b = 10;
//            MethodB(ref a, ref b);
//            Console.WriteLine("Method A: {0},{1}", a, b);
//        }

//        public void MethodB(ref int a, ref int b)
//        {
//            Console.WriteLine("Method B: {0},{1}", a, b);
//            a *= 2; b *= 2;
//        }
//    }
//}

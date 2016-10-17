//using System;

//namespace Ch07
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ExampleOfFunc exampleOfFunc = new ExampleOfFunc();

//            Console.WriteLine("{0}", exampleOfFunc.Addition(
//                exampleOfFunc.Add,                              	/* Pass method name */
//                1, 2, 3, 4, 5));

//            Console.WriteLine("{0}", exampleOfFunc.Addition(
//                (a, b, c, d, e) =>
//                {
//                    return a + b + c + d + e;
//                },                                              		/* Pass anonymous method */
//                1, 2, 3, 4, 5));
//        }
//    }

//    public class ExampleOfFunc
//    {
//        public int Addition(
//            Func<int, int, int, int, int, int> additionImplementor,
//            int a,
//            int b,
//            int c,
//            int d,
//            int e)
//        {
//            if (additionImplementor != null)
//                return additionImplementor(a, b, c, d, e);

//            return default(int);
//        }

//        public int Add(int a, int b, int c, int d, int e)
//        {
//            return a + b + c + d + e;
//        }
//    }
//}

//using System;

//namespace Ch07
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ExampleOfFunc exampleOfFunc = new ExampleOfFunc();

//            Console.WriteLine("{0}", exampleOfFunc.Addition(exampleOfFunc.Add));
//            Console.WriteLine("{0}", exampleOfFunc.Addition(
//    () =>
//    {
//        return 100 + 100;
//    }));
//        }
//    }

//    public class ExampleOfFunc
//    {
//        public int Addition(Func<int> additionImplementor)
//        {
//            if (additionImplementor != null)
//                return additionImplementor();
//            return default(int);
//        }

//        public int Add()
//        {
//            return 1 + 1;
//        }
//    }
//}

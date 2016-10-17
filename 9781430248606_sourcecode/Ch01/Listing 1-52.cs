//using System;
//namespace Ch01
//{
//    class Program
//    {
//        static void Main()
//        {
//            AClass anObjectOfAClass = new AClass();
//            anObjectOfAClass.Method1();
//            anObjectOfAClass.Method2();
//            Console.ReadLine();
//        }
//    }

//    public abstract class BaseClass { public abstract void Method1();}

//    public class BaseClass2 : BaseClass
//    {
//        public override void Method1()
//        {
//            Console.WriteLine(
//                   "Method1 of the BaseClass overridden in the BaseClass2");
//        }

//        public virtual void Method2()
//        { Console.WriteLine("Method2 define as virtual in the BaseClass2"); }

//    }
//    public class AClass : BaseClass2
//    {
//        public override void Method1()
//        { Console.WriteLine("Method1 of the AClass overridden"); }
//        public override void Method2()
//        { Console.WriteLine("Method2 of the AClass overridden"); }
//    }
//}

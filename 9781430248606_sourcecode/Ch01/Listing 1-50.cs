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

//            BClass anObjectOfBClass = new BClass();
//            anObjectOfBClass.Method1();
//            Console.ReadLine();
//        }
//    }

//    public class BaseClass
//    {
//        public virtual void Method1() { Console.WriteLine(ToString()); }
//        public virtual void Method2() { Console.WriteLine(ToString()); }
//    }

//    public class AClass : BaseClass
//    {
//        public override void Method1() { Console.WriteLine(ToString()); }
//        public sealed override void Method2()
//        { Console.WriteLine(ToString()); }
//    }

//    public class BClass : AClass
//    {
//        public override void Method1() { Console.WriteLine("Overriden"); }
//    }
//}

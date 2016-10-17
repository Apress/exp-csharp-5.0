//using System;

//namespace Ch13
//{
//    class MainClass
//    {
//        static void Main(string[] args)
//        {
//            ExceptionInMethodStateDescription exInMSD =
//                new ExceptionInMethodStateDescription();
//            exInMSD.MethodOne();
//            exInMSD.MethodTwo();
//            exInMSD.MethodThree();
//        }
//    }

//    public class ExceptionInMethodStateDescription
//    {
//        public void MethodOne()
//        {
//            try { }
//            catch (IndexOutOfRangeException indexOutOfRangeException) { }
//        }
//        public void MethodTwo()
//        {
//            try { }
//            catch (ArgumentException argumentException) { }
//        }
//        public void MethodThree()
//        {
//            try { }
//            catch (Exception exception) { }
//        }
//    }
//}

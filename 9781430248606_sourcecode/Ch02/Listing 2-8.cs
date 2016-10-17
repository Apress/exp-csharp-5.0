//using System;

//namespace Ch02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int aInt = 2012;
//            string aStringLiteral = "Expert C# 5.0: with the .NET 4.5 Framework";
//            TestClass testClass = new TestClass();

//            Console.WriteLine("{0} {1}.",
//                testClass.CastingString(aStringLiteral),
//                testClass.BoxInt(aInt));
//        }
//    }

//    public class TestClass
//    {

//        public int BoxInt(object aInt)
//        {
//            int unboxedInt = 0;
//            unboxedInt = (int)aInt;
//            return unboxedInt;
//        }

//        public string CastingString(object aStringLieteral)
//        {
//            string unboxedString = string.Empty;
//            unboxedString = (string)aStringLieteral;
//            return unboxedString;
//        }
//    }
//}

//namespace Ch04
//{
//    using System;

//    /* CH04_Extensions has to declare here otherwise compiler-time error occurred. */
//    using Ch04_Extensions;

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string data = "abcd";
//            Console.WriteLine("{0}", data.GetLastCharacter());
//        }
//    }
//}

///* Extension method defined in the  Ch04_ExtensionMethods class which reside 
// * in the Ch04_Extensions namespace */
//namespace Ch04_Extensions
//{
//    public static class Ch04_ExtensionMethods
//    {
//        public static string GetLastCharacter(this string data)
//        {
//            if (data == null || data == string.Empty) return string.Empty;
//            return data[data.Length - 1].ToString();
//        }
//    }
//}

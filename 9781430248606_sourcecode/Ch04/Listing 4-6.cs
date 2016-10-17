//using System;

//namespace Ch04
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string data = "abcd";
//            Console.WriteLine("{0}", data.GetLastCharacter());    /* Calls extension defined for the string type. */
//        }
//    }
//    public static class Ch04_ExtensionMethods  		    /* A Static class defined */
//    {
//        public static string GetLastCharacter(this string data) 	    /* A static method with the parameter 
//                             * this along with the type name string */
//        {
//            if (data == null || data == string.Empty)
//                return string.Empty;
//            return data[data.Length - 1].ToString();
//        }
//        public static Int32 GetNum(this Int32 dd)
//        {
//            return dd;
//        }
//    }
//}

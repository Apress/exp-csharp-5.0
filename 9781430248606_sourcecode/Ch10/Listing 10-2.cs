//using System;
//using System.Text;
//namespace Ch10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string bookName = "Expert C# 5.0: with the .NET 4.5 Framework";
//            /* CLR will create a String with - by repeating the number 
//                 * of the Length of the bookName string .*/
//            string dashedLine = new string('-', bookName.Length);
//            StringBuilder sb = new StringBuilder("by Mohammad Rahman");

//            Console.WriteLine("{0}\n{1}\n{2}",
//                bookName,       	/* C# Compiler include the String Literal 
// * used in bookName in metadata */
//                dashedLine,     	/* C# Compiler does not include the 
// * String Literal used in dashedLine 
// * in metadata */
//                sb.ToString()); 	/* C# Compiler include the String Literal 
// * used in the constructor in metadata and 
//                                     * will construct the String at runtime 
// * using StringBuilder */
//        }
//    }
//}

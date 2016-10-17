//using System;
//using System.Text;
//using System.IO;

//namespace Ch13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append("StringBuilder\n");

//            using (StringWriter sw = new StringWriter(sb))
//            {
//                sw.WriteLine("StringWriter");
//            }
//            Console.WriteLine("{0}", sb.ToString());
//        }
//    }
//}

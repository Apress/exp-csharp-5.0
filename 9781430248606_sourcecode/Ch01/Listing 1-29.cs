//using System;
//using System.IO;
//using System.Text;

//namespace Ch01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MethodB();
//        }

//        public static void MethodB()
//        {
//            using (MemoryStream ms =
//                   new MemoryStream(Encoding.ASCII.GetBytes("Expert C# 5.0")))
//            {
//                int i = 0;
//                do
//                {
//                    int current = ms.ReadByte();
//                    Console.Write("{0}\t{1}\n", current, (char)current);
//                } while (++i < ms.Length);
//            }
//        }
//    }
//}

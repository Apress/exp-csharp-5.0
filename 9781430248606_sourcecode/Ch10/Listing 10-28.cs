//using System;
//using System.Text;

//namespace Ch10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("{0}", ConcatUsingStringBuilder(
//                "Expert C# 5.0: with the .NET 4.5 Framework ",
//                "by Mohammad Rahman"));
//            Console.WriteLine("{0}", ConcatUsingStringBuilder());
//        }

//        static string ConcatUsingStringBuilder(string str0, string str1)
//        {
//            StringBuilder builder = new StringBuilder();
//            builder.Append(str0).Append("\t");
//            builder.Append(str1).Append("\t");
//            return builder.ToString();
//        }

//        static string ConcatUsingStringBuilder()
//        {
//            StringBuilder builder = new StringBuilder();

//            bool boolValue = true;
//            byte byteValue = 1;
//            char charValue = 'A';
//            decimal decimalValue = 10;
//            double doubleValue = 100;
//            short shortValue = 1000;
//            char[] charArrayValue = new char[] { 'A', 'B', 'C' };
//            int intValue = 10000;
//            long longValue = 100000;
//            object objectValue = new object();
//            sbyte sByteValue = 2;
//            float floatValue = 200;
//            string stringValue = "Expert C# 5.0: with the .NET 4.5 Framework";
//            ushort ushortValue = 10;
//            uint uintValue = 4;
//            ulong ulongValue = 400;

//            builder
//                .Append(boolValue).Append("\t")
//                .Append(byteValue).Append("\t")
//                .Append(charValue).Append("\t")
//                .Append(decimalValue).Append("\t")
//                .Append(doubleValue).Append("\t")
//                .Append(shortValue).Append("\t")
//                .Append(charArrayValue).Append("\t")
//                .Append(intValue).Append("\t")
//                .Append(longValue).Append("\t")
//                .Append(objectValue).Append("\t")
//                .Append(sByteValue).Append("\t")
//                .Append(floatValue).Append("\t")
//                .Append(stringValue).Append("\t")
//                .Append(ushortValue).Append("\t")
//                .Append(uintValue).Append("\t")
//                .Append(ulongValue).Append("\t")
//                .Append(charValue, 10).Append("\t")
//                .Append(stringValue, 1, 2).Append("\t")
//                .Append(charArrayValue, 1, 2);

//            return builder.ToString();
//        }
//    }
//}

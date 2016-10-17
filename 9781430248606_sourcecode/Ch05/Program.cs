//using System;

//namespace Ch05
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var anObjectOfAnonymousType = new
//            {
//                Name = "Expert C# 5.0: with the .NET 4.5 Framework",
//                Language = "C#",
//                PublishedOn = 2012,
//                Description = new DescriptionAboutBook("This book is about C#")
//            };

//            Console.WriteLine("{0}\n{1}\n{2}\n{3}",
//                anObjectOfAnonymousType.Name,
//                anObjectOfAnonymousType.Language,
//                anObjectOfAnonymousType.PublishedOn,
//                anObjectOfAnonymousType.Description.Description);
//        }
//    }
//    public class DescriptionAboutBook
//    {
//        public DescriptionAboutBook(string data)
//        {
//            Description = data;
//        }
//        public string Description { get; set; }
//    }
//}
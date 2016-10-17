//using System;

//namespace Ch10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Book book = new Book();
//            Console.WriteLine(
//                book.
//                SetBookName("Expert C# 5.0: with the .NET 4.5 Framework").
//                SetPublishedYear(2012).ToString());
//        }
//    }

//    public class Book
//    {
//        private string bookName = default(string);
//        private Int32 publishedYear = default(int);

//        public Book SetBookName(string nameOfTheBook)
//        {
//            bookName = nameOfTheBook;
//            return this;
//        }

//        public Book SetPublishedYear(int yearOfThePublication)
//        {
//            publishedYear = yearOfThePublication;
//            return this;
//        }

//        public override string ToString()
//        {
//            return string.Format("{0}:{1}", bookName, publishedYear);
//        }
//    }
//}

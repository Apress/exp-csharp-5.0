//using System;

//namespace Ch01
//{
//    public delegate void EventHandler(string name);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Book book = new Book();
//            book.ShowBookName += new EventHandler(book_ShowBookName);
//            book.Name = "Expert C# 5.0 with .NET Framework 4.5";
//            Console.WriteLine(book.Name);
//        }

//        static void book_ShowBookName(string name)
//        {
//            Console.WriteLine(name);
//        }
//    }

//    public class Book
//    {
//        public event EventHandler ShowBookName;
//        private string name;

//        public string Name
//        {
//            set
//            {
//                BookEventArgs eventArgs = new BookEventArgs()
//                {
//                    BookName = "Book name updated...."
//                };
//                name = value;
//                OnNameChanged(eventArgs);
//            }
//            get
//            {
//                return name;
//            }

//        }

//        protected virtual void OnNameChanged(BookEventArgs args)
//        {
//            EventHandler handler = ShowBookName;
//            if (handler != null)
//            {
//                handler(args.BookName);
//            }
//        }
//    }
//    public class BookEventArgs : EventArgs
//    {
//        public string BookName { get; set; }
//    }

//}

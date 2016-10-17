//using System;

//namespace Ch13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Year year = new Year();
//                year.GetMonth(22);
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine("{0}", exception.StackTrace);
//            }
//        }
//    }

//    public class Year
//    {
//        public string GetMonth(int position)
//        {
//            try
//            {
//                MonthNameFinder monthFinder = new MonthNameFinder();
//                return monthFinder.Find(position);
//            }
//            catch (Exception exception)
//            {
//                throw;
//            }
//        }
//    }

//    public class MonthNameFinder
//    {
//        private string[] months =
//        {
//            "January",          "February",
//            "March",            "April",
//            "May",               "June",
//            "July",                "August",
//            "September",     "October",
//            "November",     "December"
//        };

//        public string Find(int whichMonth)
//        {
//            try
//            {
//                return months[whichMonth];
//            }
//            catch (Exception exception)
//            {
//                throw;
//            }
//        }
//    }
//}

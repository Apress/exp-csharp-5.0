//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<object> numbers = new List<object>() 
//            { 
//                "One",
//                "Two",
//                1,
//                2,
//                "Three",
//                new Person
//                { 
//                     Name="A Person"
//                }
//            };

//            var filteredNumbers = numbers.OfType<string>();

//            filteredNumbers.ToList().ForEach(x => Console.Write("{0}\t", x));
//            Console.WriteLine();
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }
//    }
//}

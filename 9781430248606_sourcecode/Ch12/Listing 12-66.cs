//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//namespace Ch12
//{
//    public struct MyStruct
//    {
//        public string Name { get; set; }
//    }
//    public class Person
//    {
//        public string PersonID { get; set; }
//        public int PersonAge { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> series = new List<string> { "One", "Two", "Three" };
//            List<MyStruct> names = new List<MyStruct> 
//            { 
//                new MyStruct{ Name="A"}, 
//                new MyStruct{ Name="B"}, 
//            };
//            List<Person> persons = new List<Person> 
//            { 
//                 new Person { PersonID = "PA_01", PersonAge = 6 }, 
//                new Person { PersonID = "PB_01", PersonAge = 7 }, 
//            };
//            // outout will be null
//            var item = series.ElementAtOrDefault(8);
//            // Output contain an instnce of MyStruct in where Name will be null
//            var name = names.ElementAtOrDefault(8);
//            //Output will be null
//            var person = persons.ElementAtOrDefault(8);
//        }
//    }
//}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IList<Person> persons = new List<Person>() 
//            { 
//                new Person(){ Name="Person F", Address= "Address of F",  
//                              Id= 111116},
//                new Person(){ Name="Person G", Address= "Address of G", 
//                              Id= 111117},
//                new Person(){ Name="Person C", Address= "Address of C",  
//                              Id= 111113},
//                new Person(){ Name="Person B", Address= "Address of B", 
//                              Id= 111112},
//                new Person(){ Name="Person D", Address= "Address of D", 
//                              Id= 111114},
//                new Person(){ Name="Person A", Address= "Address of A", 
//                              Id= 111111},
//                new Person(){ Name="Person E", Address= "Address of E", 
//                              Id= 111115}                
//            };

//            var result =
//                persons.OrderBy(person => person.Id).ThenBy(person => person);

//            foreach (Person person in result)
//            {
//                Console.WriteLine("{0,-15} {1,-20}{2,-20}",
//                    person.Name,
//                    person.Address,
//                    person.Id);
//            }
//        }
//    }

//    public class Person
//    {
//        public string Name
//        {
//            get;
//            set;
//        }

//        public string Address
//        {
//            get;
//            set;
//        }

//        public double Id
//        {
//            get;
//            set;
//        }
//    }
//}

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
//                new Person(){ Name="Person A", Address= "Address of A", 
//                              Id= 111111},
//                new Person(){ Name="Person B", Address= "Address of B", 
//                              Id= 111112},
//                new Person(){ Name="Person C", Address= "Address of C", 
//                              Id= 111113},
//                new Person(){ Name="Person D", Address= "Address of D", 
//                              Id= 111114},
//            };

//            var result = persons.ToDictionary(person => person.Id);

//            foreach (KeyValuePair<double, Person> person in result)
//            {
//                Console.WriteLine("{0,-15} {1,-20}{2,-20}{3,-20}",
//                    person.Key,
//                    person.Value.Name,
//                    person.Value.Address,
//                    person.Value.Id);
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

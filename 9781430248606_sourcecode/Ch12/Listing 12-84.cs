//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Person> persons = CreatePersonList();

//            var result = persons.ToLookup(
//                (key) => key.Name,
//                (groupItem) => groupItem.Address);

//            result.ToList().ForEach(item =>
//            {
//                Console.Write("Key:{0,11}\nValue:\t{1,12}\n",
//                    item.Key,
//                    string.Join("\n\t", item.Select(groupItem =>
//                        groupItem).ToArray()));
//            });
//        }

//        private static List<Person> CreatePersonList()
//        {
//            return new List<Person>()
//            {
//                new Person{ Name="APerson",  	Address="APerson's Address"},
//                new Person{ Name="AAPerson", 	Address="AAPerson's Address"},
//                new Person{ Name="APerson",  	
//                            Address="APerson's Second Address"},
//                new Person{ Name="BPerson",  	Address="BPerson's Address"},
//                new Person{ Name="BBPerson", 	Address="BBPerson's Address"},
//                new Person{ Name="BPerson",  	
//                            Address="BPerson's Second Address"},
//                new Person{ Name="CPerson",  	Address="CPerson's Address"},
//                new Person{ Name="CCPerson", 	Address="CCPerson's Address"},
//                new Person{ Name="CPerson",  	
//                            Address="CPerson's Second Address"},                
//            };
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }
//        public string Address { get; set; }
//    }
//}

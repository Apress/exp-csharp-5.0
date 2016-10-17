//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Person> persons;
//            InitializeData(out persons);

//            var result = persons.GroupBy(
//                person => person.PersonAge,
//                person => person.PersonID,
//                (Age, Id) =>
//                    new
//                    {
//                        PersonAge = Age,
//                        PersonID = Id
//                    }
//                );

//            Console.WriteLine("Age group \t No of person \t Persons are");
//            result.ToList().ForEach(item =>
//                Console.WriteLine(
//                    string.Format("{0,5} \t {1,15} \t {2,-33}",
//                        item.PersonAge,
//                        item.PersonID.Count(),
//                        string.Join(",", item.PersonID))));
//        }

//        private static void InitializeData(
//            out List<Person> persons)
//        {
//            persons = new List<Person>
//            {
//                new Person { PersonID = "PA_01", PersonAge = 6 },
//                new Person { PersonID = "PB_01", PersonAge = 7 },
//                new Person { PersonID = "PC_01", PersonAge = 7 },
//                new Person { PersonID = "PD_01", PersonAge = 4 },
//                new Person { PersonID = "PE_01", PersonAge = 7 },
//                new Person { PersonID = "PF_01", PersonAge = 5 },
//                new Person { PersonID = "PG_01", PersonAge = 5 },
//                new Person { PersonID = "PH_01", PersonAge = 9 },
//                new Person { PersonID = "PI_01", PersonAge = 9 }
//            };
//        }
//    }

//    public class Person
//    {
//        public string PersonID { get; set; }
//        public int PersonAge { get; set; }
//    }
//}

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
//            List<Address> addresses;
//            InitializeData(out persons, out addresses);

//            /* persons - Outer Sequence */
//            var result = persons.GroupJoin(
//                /*addresses - Inner Sequence*/
//                addresses,
//                /* Outer Key Selector */
//                person => person,
//                /* Inner Key Selector */
//                address => address.AddressOf,
//                /* Result Selector */
//                (person, address) =>
//                    new
//                    {
//                        PersonName = person.PersonName,
//                        AddressDetails =
//                        address.Select(innerAddress => innerAddress.AddressDetails)
//                    }
//                );

//            var rr = result.ToList();
//            foreach (var item in result)
//            {
//                Console.WriteLine("{0}", item.PersonName);
//                item.AddressDetails.ToList().ForEach(
//                    address => Console.WriteLine(address));
//            }
//        }

//        private static void InitializeData(
//            out List<Person> persons, out List<Address> addresses)
//        {
//            var personA = new Person { PersonID = "PA_01", PersonName = "A" };
//            var personB = new Person { PersonID = "PB_01", PersonName = "B" };
//            var personC = new Person { PersonID = "PC_01", PersonName = "C" };

//            var addressOne = new Address { AddressOf = personA, AddressDetails = "Mystery Street,Jupiter" };
//            var addressTwo = new Address { AddressOf = personA, AddressDetails = "Dark Street,Mars" };
//            var addressThree = new Address { AddressOf = personB, AddressDetails = "Sun Street,Jupiter" };
//            var addressFour = new Address { AddressOf = personC, AddressDetails = "Dry Street,Neptune" };

//            persons = new List<Person> { personA, personB, personC };
//            addresses = new List<Address> { addressOne, addressTwo, addressThree, addressFour };
//        }
//    }

//    public class Person
//    {
//        public string PersonID { get; set; }
//        public string PersonName { get; set; }
//    }

//    public class Address
//    {
//        public Person AddressOf { get; set; }
//        public string AddressDetails { get; set; }
//    }
//}
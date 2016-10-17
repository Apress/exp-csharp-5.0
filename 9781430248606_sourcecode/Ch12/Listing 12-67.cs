//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace Ch12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            IList<Person> persons = new List<Person>();
//            IList<int> numbers = new List<int>();
//            IList<string> names = new List<string>();
//            /* Output: A list with 1 item with the null value */
//            var defaultPersons = persons.DefaultIfEmpty();
//            /*Output: A list with 1 item with the 0 value */
//            var defaultNumbers = numbers.DefaultIfEmpty().ToList();
//            /* Output: A list with 1 item with the null value */
//            var defaultNames = names.DefaultIfEmpty();
//        }
//    }

//    class Person
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

//        public int Age
//        {
//            get;
//            set;
//        }
//    }
//}

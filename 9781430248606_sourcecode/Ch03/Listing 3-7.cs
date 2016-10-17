//using System;

//namespace Ch03
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ObjectAsValue temp = new ObjectAsValue();
//            temp.MethodA();
//        }
//    }

//    public class ObjectAsValue
//    {
//        public ObjectAsValue()
//        {
//            Console.WriteLine("Object as value");
//        }
//        public void MethodA()
//        {
//            Person aPerson = new Person()
//            {
//                Name = "APerson"
//            };
//            MethodB(aPerson);
//            Console.WriteLine("Method A: {0}", aPerson.Name);
//        }
//        public void MethodB(Person aPerson)
//        {
//            Console.WriteLine("Method B: {0}", aPerson.Name);
//            aPerson.Name = "Updated" + aPerson.Name;
//        }
//    }

//    public class Person
//    {
//        public string Name
//        { get; set; }
//    }
//}

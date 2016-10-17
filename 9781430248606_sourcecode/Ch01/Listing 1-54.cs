//using System;
//namespace Ch01
//{
//    public delegate void EventHandler(string name);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Planets planets = new Planets();
//            for (int i = 0; i <= 8; ++i)
//                Console.Write("{0}\t", planets[i]);
//            Console.ReadLine();
//        }
//    }

//    public class Planets
//    {
//        private string[] nameOfThePlanets = 
//            { "Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", 
//              "Saturn", "Uranus", "Neptune" };

//        public string this[int index]
//        {
//            get
//            {
//                return nameOfThePlanets[index];
//            }
//            set
//            {
//                nameOfThePlanets[index] = value;
//            }
//        }
//    }
//}

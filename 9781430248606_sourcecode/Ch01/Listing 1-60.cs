//using System;
//namespace Ch01
//{
//    class Program
//    {
//        public enum Planets
//        {
//            Sun,
//            Mercury,
//            Venus,
//            Earth,
//            Mars,
//            Jupiter,
//            Saturn,
//            Uranus,
//            Neptune
//        }
//        static void Main()
//        {
//            DisplayInformation(Planets.Earth);
//            DisplayInformation(Planets.Mars);
//            DisplayInformation(Planets.Jupiter);
//        }
//        static void DisplayInformation(Planets planets)
//        {
//            switch (planets)
//            {
//                case Planets.Earth:
//                    Console.WriteLine("Third planet from the Sun");
//                    break;
//                case Planets.Mars:
//                    Console.WriteLine("The fourth planet from the Sun");
//                    break;
//                default:
//                    Console.WriteLine("Please provide valid Planet name");
//                    break;
//            }
//        }
//    }
//}

//using System;
//using System.Linq;

//namespace Ch06
//{
//    class Program
//    {
//        public enum Planets
//        {
//            Sun = 0,        	/* Otherwise compiler will assign default value */
//            Mercury,        	/* compiler will assign 1 */
//            Venus,          	/* compiler will assign 2 */
//            Earth,          	/* compiler will assign 3 */
//            Mars,           	/* compiler will assign 4 */
//            Jupiter,        	/* compiler will assign 5 */
//            Saturn,         	/* compiler will assign 6 */
//            Uranus,         	/* compiler will assign 7 */
//            Neptune         	/* compiler will assign 8 */
//        }

//        static void Main(string[] args)
//        {
//            string enumItemToFind = "Jupiter";
//            Console.WriteLine(
//                "Is {0}, has been defined in the Planets enum? {1}",
//                enumItemToFind,
//                Enum.IsDefined(typeof(Planets), enumItemToFind));
//        }
//    }
//}

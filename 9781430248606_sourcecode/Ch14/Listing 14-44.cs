//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task combinedResult = TestDelayWithWhenAny();

//            while (true)
//            {
//                if (combinedResult.IsCompleted)
//                {
//                    Console.WriteLine("Finished waiting");
//                    break;
//                }
//                Console.Write(".");
//            }
//            Console.ReadLine();
//        }

//        public static async Task TestDelayWithWhenAny()
//        {
//            await Task.WhenAny(Task.Delay(1), Task.Delay(2000));
//        }
//    }
//}

//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            MultipleAwait();

//            for (int i = 0; i < Int16.MaxValue * 8; ++i)
//            {
//                if (i / byte.MaxValue == 0)
//                    Console.Write(">");
//            }
//            Console.WriteLine("Operation is completed.");
//            Console.ReadLine();
//        }
//        public static async void MultipleAwait()
//        {
//            await EvenNumbers();
//            await EvenNumbers();
//        }

//        public static async Task EvenNumbers()
//        {
//            int limit = new Random().Next(Int16.MaxValue);
//            Task<int> evenNumbersTask = Task.Run(
//                 () => Enumerable.Range(1, limit).Count(
//               item => item % 2 == 0));
//            await evenNumbersTask;
//            Console.WriteLine("\n" + evenNumbersTask.Result);
//        }
//    }
//}

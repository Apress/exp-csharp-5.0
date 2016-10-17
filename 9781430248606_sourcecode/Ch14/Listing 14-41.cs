//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task<int> combinedResult = TestWhenAll();
//            while (true)
//            {
//                if (combinedResult.IsCompleted)
//                {
//                    Console.WriteLine("Finished : {0}", combinedResult.Result);
//                    break;
//                }
//                Console.Write(".");
//            }
//            Console.ReadLine();
//        }

//        public static async Task<int> TestWhenAll()
//        {
//            int[] combinedResult =
//    await Task.WhenAll(CountEvenNumbers(),
//                          CountEvenNumbers(), CountEvenNumbers());
//            return combinedResult.Sum();
//        }

//        public static async Task<int> CountEvenNumbers()
//        {
//            return await Task.Run(
//            () => Enumerable.Range(1, Int16.MaxValue).Count(x => x % 2 == 0));
//        }
//    }
//}

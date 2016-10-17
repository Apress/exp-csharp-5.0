//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task<int> result = TestWhenAny();
//            while (true)
//            {
//                if (result.IsCompleted)
//                {
//                    Console.WriteLine("Finished : {0}", result.Result);
//                    break;
//                }
//                Console.Write(".");
//            }
//            Console.ReadLine();
//        }

//        public static async Task<int> TestWhenAny()
//        {
//            Task<int> firstCompleted =
//    await Task.WhenAny(CountEvenNumbers(),
//                          CountEvenNumbers(), CountEvenNumbers());
//            return firstCompleted.Result;
//        }

//        public static async Task<int> CountEvenNumbers()
//        {
//            return await Task.Run(() => Enumerable.Range(1,
//                                   Int16.MaxValue).Count(x => x % 2 == 0));
//        }
//    }
//}

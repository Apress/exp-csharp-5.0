//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            FireAndForget();

//            for (int i = 0; i < Int32.MaxValue; ++i)
//            {
//                if (i % (Int16.MaxValue * 999) == 0)
//                    Console.Write(".");
//            }
//            Console.ReadLine();
//        }

//        public static async void FireAndForget()
//        {
//            var evenNumbersTask = Task.Run(
//                () =>
//                {
//                    Enumerable.Range(1, 5).ToList().ForEach(itemOuter =>
//                    {
//                        int limit = new Random().Next(Int16.MaxValue * 999);
//                        var result = Enumerable.Range(
//                        itemOuter, limit).Count(item =>
//                        {
//                            return item % 2 == 0;
//                        });
//                        Console.WriteLine(
//                           "\nProcessing and processed result {0}.", result);
//                    });
//                });
//            await evenNumbersTask;
//        }
//    }
//}

//using System;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            CancellationTokenSource cancelSource = new
//                                    CancellationTokenSource();
//            Progress<int> progressReport = new Progress<int>((status) =>
//            {
//                Console.Clear();
//                Console.WriteLine(status + " %");
//            });
//            Task showNumber = ShowEvenNumbers(cancelSource.Token,
//                                              progressReport);

//            for (int i = 0; i < Int64.MaxValue; ++i)
//                if (i == Int32.MaxValue)
//                {
//                    cancelSource.Cancel();
//                    break;
//                }
//            Console.WriteLine("Cancel");
//            Console.ReadLine();
//        }

//        public static async Task ShowEvenNumbers(
//            CancellationToken cancelToken,
//            IProgress<int> onProgressChanged)
//        {
//            int limit = new Random().Next(Int32.MaxValue);
//            string range = string.Format("({0},{1})", 1, limit);

//            Task<int> evenNumbersTask = Task.Run(
//                () => Enumerable.Range(1, limit).Count(item =>
//                {
//                    onProgressChanged.Report((item * 100) / limit);
//                    return item % 2 == 0;
//                }), cancelToken);
//            int count = await evenNumbersTask;
//        }
//    }
//}

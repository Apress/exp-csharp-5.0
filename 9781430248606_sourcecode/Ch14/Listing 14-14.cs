//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            ShowEvenNumbers();
//            Console.WriteLine("Waiting.....");
//            for (int i = 0; i <= Int16.MaxValue * 100; ++i) ;
//            Console.ReadLine();
//        }

//        static void ShowEvenNumbers()
//        {
//            Task<int> evenNumbersTask = Task.Run(
//                      () => Enumerable.Range(1,
//                                       new Random().Next(Int16.MaxValue)).
//                                       Count(item => item % 2 == 0));

//            evenNumbersTask.ContinueWith(task =>
//            {
//                Console.WriteLine("Complete, Total no of even : {0}",
//                                                        task.Result);
//            });

//            Console.WriteLine("Schedule to complete...");
//        }
//    }
//}

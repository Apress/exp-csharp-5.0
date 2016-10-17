//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task<string> displayTask = Task.Run(() =>
//            {
//                /* To simulate as doing something.*/
//                for (int i = 0; i <= Int16.MaxValue; ++i) ;
//                return "async in C# 5.0";
//            });
//            Console.WriteLine("Result from the Task : {0}",
//                              displayTask.Result);

//            if (displayTask.IsCompleted)
//                Console.Write(TaskStatus.RanToCompletion.ToString());
//            if (displayTask.IsCanceled)
//                Console.Write(TaskStatus.Canceled.ToString());
//            if (displayTask.IsFaulted)
//                Console.Write(TaskStatus.Faulted.ToString());
//            Console.ReadLine();
//        }
//    }
//}

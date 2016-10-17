//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task displayTask = Task.Run(
//                 () => Console.WriteLine("async in C# 5.0"));

//            Console.WriteLine(
//                   "Task completion status : {0}, waiting to finish....",
//                   displayTask.IsCompleted);
//            displayTask.Wait();
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            /* A task will be instantiated and scheduled to run sometime 
//             * later on and 
//             * return the instance of the Task to displayTask variable. */
//            Task displayTask = Task.Run(() =>
//                                    Console.WriteLine("async in C# 5.0"));

//            /* Continue until the task completes */
//            while (true)
//            {
//                /* To check whether the task has completed or not */
//                if (displayTask.IsCompleted)
//                {
//                    Console.WriteLine("Task completed!");
//                    break;
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}

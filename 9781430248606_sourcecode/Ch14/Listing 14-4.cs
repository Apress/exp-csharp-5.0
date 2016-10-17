//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            /* An instance of the Task will be instantiated. */
//            Task displayTask = new Task(
//                /* The Task will execute the Action block */
//                () => Console.WriteLine("async in C# 5.0"),
//                /* Task creation options */
//                TaskCreationOptions.None
//                );

//            displayTask.Start();
//            /* The Task will execute sometimes later */
//            displayTask.Wait();
//            /* Explicitly wait for the task to finish */
//            Console.ReadLine();
//        }
//    }
//}

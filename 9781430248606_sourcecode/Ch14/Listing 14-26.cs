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
//            Console.WriteLine("{0,15}{1,46}{2,15}",
//                              "Method", "Description", "Thread Id");
//            Console.WriteLine("{0,15}{1,46}{2,15}",
//                "Main", "Start Processing.....",
//                Thread.CurrentThread.ManagedThreadId);

//            /* Call an async method */
//            Task showNumber = ShowEvenNumbers();

//            /* The for loop used to simulate as something else is executing 
//             * while the asynchronous operation is executing it's task.*/
//            for (int i = 0; i < Int64.MaxValue; ++i)
//                if (i % Int32.MaxValue == 0)
//                    Console.WriteLine("{0,15}{1,46}{2,15}",
//                        "Main", "something else is doing......",
//                        Thread.CurrentThread.ManagedThreadId);
//                /* Checking the Task whether it's completed or not */
//                else if (showNumber.IsCompleted)
//                    break;

//            Console.WriteLine("{0,15}{1,46}{2,15}",
//                "Main", "Finished execution",
//                Thread.CurrentThread.ManagedThreadId);
//            Console.ReadLine();
//        }

//        public static async Task ShowEvenNumbers()
//        {
//            Console.WriteLine("{0,15}{1,46}{2,15}", "ShowEvenNumbers",
//                "Processing is continuing.....",
//                Thread.CurrentThread.ManagedThreadId);
//            int limit = new Random().Next(Int32.MaxValue);
//            string range = string.Format("({0},{1})", 1, limit);

//            /* Initialize and schedule a Task to run sometime later on.*/
//            Task<int> evenNumbersTask = Task.Run(
//                () => Enumerable.Range(1, limit).Count(item => item % 2 == 0));

//            /* The await statement await the Task to complete later by 
//             * set up the continuation code block to execute after the 
//             * Task finishes it's job.*/
//            int count = await evenNumbersTask;

//            /* Following code block will be used as the continuation code 
//             * block for the evenNumbersTask and it will be setup by 
//             * the C# compiler. */
//            Console.WriteLine("{0,15}{1,46}{2,15}", "ShowEvenNumbers",
//                string.Format("In {0} Total: {1} On Thread", range, count),
//                Thread.CurrentThread.ManagedThreadId);
//            Console.WriteLine("{0,15}{1,46}{2,15}", "ShowEvenNumbers",
//                "Processing is finished.....",
//                Thread.CurrentThread.ManagedThreadId);
//        }
//    }
//}

//using System;
//using System.Linq;
//using System.Runtime.CompilerServices;
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
//            /* A Task is instantiated*/
//            Task<int> evenNumbersTask = Task.Run(
//                      () => Enumerable.Range(1,
//                      new Random().Next(Int16.MaxValue)).Count(
//                      item => item % 2 == 0));

//            /* Retrieved the awaiter from the Task instantiated earlier */
//            TaskAwaiter<int> awaiter = evenNumbersTask.GetAwaiter();

//            /* Setup the continuation block in the awaiter of the Task 
//             * evenNumbersTask */
//            awaiter.OnCompleted(() =>
//            {
//                /* Continuation code block */
//                Console.WriteLine("Complete, Total no of even : {0}",
//                                  awaiter.GetResult());
//            });

//            /* Following line or lines is not part of the continuation 
//             * code block in relation to the Task  evenNumbersTask */
//            Console.WriteLine("Schedule to complete...");
//        }
//    }
//}

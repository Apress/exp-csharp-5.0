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
//            CancellationTokenSource cancelSource = new CancellationTokenSource();

//            /* Initialize the Task with the cancel Token from 
//             * the CancellationTokenSource */
//            Task showNumber = ShowEvenNumbers(cancelSource.Token);

//            /* Following for-loop simulates as something else is going on */
//            for (int i = 0; i < Int64.MaxValue; ++i)
//                if (i == byte.MaxValue)
//                {
//                    /* Call the Cancel method to cancel the task in sometime 
//                     * when the Task was executing it's Task*/
//                    cancelSource.Cancel();
//                    break;
//                }
//            Console.WriteLine("Cancel");
//            Console.ReadLine();
//        }

//        public static async Task ShowEvenNumbers(CancellationToken cancelToken)
//        {
//            int limit = new Random().Next(Int32.MaxValue);
//            string range = string.Format("({0},{1})", 1, limit);

//            /* Pass the cancel token to the Task  */
//            Task<int> evenNumbersTask = Task.Run(
//                () => Enumerable.Range(1, limit).Count(
//              item => item % 2 == 0), cancelToken);
//            int count = await evenNumbersTask;
//        }
//    }
//}

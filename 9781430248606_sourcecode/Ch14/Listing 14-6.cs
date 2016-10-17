//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task<string> displayTask = new Task<string>(
//                         () => "async in C# 5.0", TaskCreationOptions.None);
//            displayTask.Start();
//            Console.WriteLine("Result from the Task : {0}",
//                              displayTask.Result);
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            Task displayTask = Task.Run(() =>
//            {
//                Task.Delay(500000);
//                for (int i = 0; i < byte.MaxValue; ++i) ;
//                Console.WriteLine("async in C# 5.0");
//            });

//            while (true)
//            {
//                Console.WriteLine(displayTask.Status.ToString());
//                if (displayTask.IsCompleted)
//                    break;
//            }
//            Console.WriteLine(displayTask.Status.ToString());
//            Console.ReadLine();
//        }
//    }
//}

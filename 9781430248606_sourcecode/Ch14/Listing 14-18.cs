//using System;
//using System.Threading;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            /*Instantiates an instance of the State machine */
//            StateMachine sm = new StateMachine();

//            /*Initialize the State machine with it's default value*/
//            sm.State = 1;

//            /* Start the State machine */
//            sm.MoveNext();

//            /* Queue the captured execution context with the workitem in the 
//             * ThreadPool to process later. */
//            ThreadPool.QueueUserWorkItem(state =>
//                RunLaterOn<object>(
//                    /* Get the current execution context */
//                    CaptureExecutionContext(),
//                    /* pass the callback code block */
//                    new Action<object>(Callback),
//                    /* The State machine which maintains the state */
//                    sm));

//            /* Do something else. */
//            for (int i = 0; i <= Int16.MaxValue; ++i)
//                if (i % byte.MaxValue == 0)
//                    Console.Write(".");
//            Console.ReadLine();
//        }

//        /* This code block capture the current execution context */
//        static ExecutionContext CaptureExecutionContext()
//        {
//            return ExecutionContext.Capture();
//        }

//        /* This code block will run the callback code block on the 
//         * captured execution context*/
//        static void RunLaterOn<T>(
//                    ExecutionContext context, Action<T> callback, object state)
//        {
//            ExecutionContext.Run(context,
//                                 new ContextCallback(Callback), state);
//        }

//        /* This code block used as the callback */
//        static void Callback(object state)
//        {
//            ((StateMachine)state).MoveNext();
//        }
//    }

//    /* The State machine used to maintain the state of the operation */
//    public class StateMachine
//    {
//        public int State { get; set; }

//        public void MoveNext()
//        {
//            switch (State)
//            {
//                case 0:
//                    Console.Write("State 0");
//                    State = 1;
//                    break;
//                case 1:
//                    Console.Write("State 1");
//                    for (int i = 0; i <= byte.MaxValue; ++i) ;
//                    State = 0;
//                    break;
//                default:
//                    Console.Write("State -1");
//                    State = 10;
//                    break;
//            }
//        }
//    }
//}

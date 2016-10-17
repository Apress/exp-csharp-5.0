//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Ch14
//{
//    class Program
//    {
//        static void Main()
//        {
//            int limit = new Random().Next(Int32.MaxValue);

//            var evenNumbersTask = Task.Factory.StartNew(() =>
//            {
//                var r = Task.Factory.StartNew(() =>
//                {
//                    Enumerable.Range(1, limit).Count(item =>
//                    {
//                        if (item == Int16.MaxValue)
//                            /* Out of Range will be concat with the original 
//                             * Framework given exception message */
//                            throw new ArgumentOutOfRangeException(
//                                                   "Out of Range....");
//                        return item % 2 == 0;
//                    });
//                });
//                r.Wait();
//            });

//            try
//            {
//                evenNumbersTask.Wait(); /* Wait for the Exception to occur. */
//            }
//            catch (AggregateException aggregateException)
//            {
//                aggregateException
//                    .Flatten()
//                    .InnerExceptions
//                    .Where(item => item is ArgumentOutOfRangeException)
//                    .ToList()   /* Contains ArgumentOutOfRangeException */
//                    .ForEach(age => Console.WriteLine(age.Message));
//            }
//        }
//    }
//}

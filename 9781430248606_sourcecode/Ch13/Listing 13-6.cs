//using System;

//namespace Ch13
//{
//    class MainClass
//    {
//        static void Main(string[] args)
//        {
//            ExampleOfExceptionUsage eeu = new ExampleOfExceptionUsage();
//        }
//    }

//    public class ExampleOfExceptionUsage
//    {
//        public void DoSomething()
//        {
//            try
//            {
//                /* Do some operation */
//            }

//            catch (ArgumentException argumentException)
//            {
//                /* handle ArgumentException exception */
//            }

//            catch (IndexOutOfRangeException indexOutOfRangeException)
//            {
//                /*handle IndexOutOfRangeException */
//            }

//            catch (Exception exception)
//            {
//                /* handle exception in general in here if ArgumentException
//                 * and IndexOutOfRangeException did not occurred. */
//            }

//            finally
//            {
//                Console.WriteLine("It will execute all the time");
//            }
//        }
//    }
//}

//using System;

//namespace Ch13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Salary salary = new Salary();
//                salary.CalculateSalary(10, 0);
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine("An error occured.");
//            }
//        }
//    }

//    public class Salary
//    {
//        public int CalculateSalary(int week, int rate)
//        {
//            try
//            {
//                Calculator calculator = new Calculator();
//                return week * calculator.Divide(week, rate);
//            }
//            catch (DivideByZeroException divideByZeroException)
//            {
//                throw;
//            }
//        }
//    }

//    public class Calculator
//    {
//        public int Divide(int a, int b)
//        {
//            try
//            {
//                return a / b;
//            }
//            catch
//            {
//                throw;
//            }
//        }
//    }
//}

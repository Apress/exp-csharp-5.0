using System;
namespace Ch07
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleOfFunc exampleOfFunc = new ExampleOfFunc();
            exampleOfFunc.Addition(exampleOfFunc.Add, 10, 10);
            exampleOfFunc.Addition(
(a, b) =>
{
    Console.WriteLine("{0}", a + b);
}, 20, 20);
        }
    }

    public class ExampleOfFunc
    {
        public void Addition(Action<int, int> additionImplementor, int a, int b)
        {
            if (additionImplementor != null)
                additionImplementor(a, b);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("{0}", a + b);
        }
    }
}


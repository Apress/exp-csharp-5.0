using System;
using System.Diagnostics;
using System.Threading;

namespace Ch14
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Method1();
            Method2();
            Method3();
            Method4();
            Method5();
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: {0}ms",
                              stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
        static void Method1() { Thread.Sleep(10); }
        static void Method2() { Thread.Sleep(10); }
        static void Method3() { Thread.Sleep(10); }
        static void Method4() { Thread.Sleep(10); }
        static void Method5() { Thread.Sleep(10); }
    }
}

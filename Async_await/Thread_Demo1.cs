using System;
using System.Threading;
namespace Async_await
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Thread_Demo1
    {
        public static void Main(string[] args)  
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}

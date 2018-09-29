using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Async_await
{
    public class MyThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                
                Console.WriteLine("Thread1 "+i);
            }
        }
        public static void Thread2()
        {
            for (int i = 11; i < 22; i++)
            {
                Console.WriteLine("thread2"+i);
            }
        }
    }
    public class Thread_Demo
    {
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread1));

            Thread t3 = new Thread(new ThreadStart(MyThread.Thread2));
         //   Thread t4 = new Thread(new ThreadStart(Thread1));
            t1.Start();
            t2.Start();
            t3.Start();
            t3.Join();
         //   t2.Abort();
            //  t4.Start();
            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch 
            {

                Console.WriteLine("Exception");
            }
            Console.ReadLine();
        }

        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main"+i);
            }
        }
    }
}

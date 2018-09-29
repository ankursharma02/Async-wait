using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Async_await
{
    
    class MultiThread_demo
    {
        public void demo1()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("demo1 " + i);

        }
        public void demo2()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("demo2 " + i);

        }
        public void demo3()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine("demo3 " + i);

        }
        public static void Main(string[] args)
        {
            MultiThread_demo md = new MultiThread_demo();
            Thread t1 = new Thread(new ThreadStart( md.demo1));
            Thread t2 = new Thread(new ThreadStart(md.demo2));
            Thread t3 = new Thread(new ThreadStart(md.demo3));
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

    }
}

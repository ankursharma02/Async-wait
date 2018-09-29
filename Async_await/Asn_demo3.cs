using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_await
{
    class Asn_demo3
    {
        static void Main(string[] args)
        {
            Task t= DemoAsc();
            t.Wait();
            simplemethod();
            t.Wait();
            Console.ReadLine();
        }
        static async Task DemoAsc()
        {
            Console.WriteLine("This is async method ");
            simplemethod();
            await  Task.Run(()=>
            {
                simplemethod();
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("first await run method");
                Console.WriteLine("complete");
            });
            simplemethod();
        }
        static void simplemethod()
        {
            Console.WriteLine("in simple method");
        }
    }
}

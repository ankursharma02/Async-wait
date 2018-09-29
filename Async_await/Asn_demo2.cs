using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
namespace Async_await
{
    class Asn_demo2
    {
        static void Main(string[] args)
        {
            Task<int> result = Get_fileLength();
            Console.WriteLine("length: {0}", result.Result);
            Console.ReadLine();
        }
        // Asynchronous method  
        static async Task<int> Get_fileLength()
        {
            string file = @"e:\demo.txt";
            Console.WriteLine("Counting start");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the file data somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 100; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }

    }
}

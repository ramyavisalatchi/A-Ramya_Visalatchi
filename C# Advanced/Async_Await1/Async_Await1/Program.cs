using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Method1();
            Console.Read();
        }

        public static async Task Method1()
        {
            Console.WriteLine("Method 1 called");
            var a= await Method2();
            Console.WriteLine("Method 2 returned value");
            Console.WriteLine(a);
            
        }

        public static async Task<string> Method2()
        {
            string b = "hello";
            return b;
        }

    }
}

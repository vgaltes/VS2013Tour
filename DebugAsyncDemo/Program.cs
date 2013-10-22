using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OneAsync().Wait();
        }

        async static Task OneAsync()
        {
            await TwoAsync();
        }

        async static Task TwoAsync()
        {
            await ThreeAsync();
        }

        async static Task ThreeAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("All done!");
        }
    }
}

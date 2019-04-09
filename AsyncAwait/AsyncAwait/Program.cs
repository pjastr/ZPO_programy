using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    //http://www.altcontroldelete.pl/artykuly/obsluga-wielu-taskow-na-raz-w-c/

    public class App
    {
        public async Task Run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            await Task.WhenAll(TaskA(), TaskB(), TaskC());
            watch.Stop();
            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds}ms.");
        }

        private async Task TaskA()
        {
            await Task.Delay(1500);
            Console.WriteLine("TaskA executed");
        }

        private async Task TaskB()
        {
            await Task.Delay(1000);
            Console.WriteLine("TaskB executed");
        }

        private async Task TaskC()
        {
            await Task.Delay(2000);
            Console.WriteLine("TaskC executed");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            Task.Run(async () => {
                await app.Run();
            }).Wait();
            Console.ReadKey();
        }
    }
}

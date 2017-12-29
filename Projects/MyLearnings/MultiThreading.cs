using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLearnings
{
    static class MultiThreading
    {
        static void PausePrinting()
        {
            var end = DateTime.Now + TimeSpan.FromSeconds(10);
            Console.WriteLine("waiting ..");
            while (DateTime.Now < end) { }
        }

        static async Task<int> PausePrinterAsync()
        {
            await Task.Delay(3000);
            return 1;
        }

        static async void MyMethodAsync()
        {
            Task<int> longRunningTask = PausePrinterAsync();
            Console.WriteLine("Long running task is executing ..");

            var result = await longRunningTask;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Oh, I finished!  The result value is: {0} on Thread {1}", result, Thread.CurrentThread.ManagedThreadId));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

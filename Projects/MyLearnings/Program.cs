using Algorithms;
using FactoryPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLearnings
{
    class Program
    {
        static void Main(string[] args)
        {


            //MyMethodAsync();
            //var thread = Thread.CurrentThread.ManagedThreadId;
            //for (var i = 0; i <=10000; i++)
            //{
            //    Console.WriteLine(string.Format("Long running task is executing on thread {0} for loop {1}", thread, i));
            //}
            //Console.ReadKey();


            //PausePrinting();
            //ReverseStringArray("this is a string to reverse");
            //ReverseString();
            //BubbleSortmeth();
            //FactoryPracticeClient.ReadInvoice();

            //var bridgePattern = new BridgePattern.Client();
            //StringPuzzles.FindFirstRepeatingCharacterUsingHashLookup("abcdbcd");
            //LINQ.QuerySyntax.SelectContains();
            //LINQ.QuerySyntax.SelectLamdaSearch();
            //var fixedWords = StringPuzzles.CapitalizeTitle("i'm going to correctly cAPiTALizE these words");
            DelegateConsumer.ChangeNameInGradeBook();
        }   

        static void BubbleSortmeth()
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            int t;
            Console.WriteLine("Original array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.ReadKey();
        }

        static void ReverseString()
        {
            var fullString = "this is a string to reverse";
            var len = fullString.Length;
            string reversedString = null;

            for (int i = len-1; i >= 0; i--)
            {
                var s = fullString.Substring(i, 1);
                reversedString = reversedString + s;
            }
        }

        static void ReverseStringArray(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
        }

        
        static void BubbleSortAgain(int[] a)
        {

        }

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

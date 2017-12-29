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
        
    }
}

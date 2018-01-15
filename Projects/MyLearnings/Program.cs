using Algorithms;
using FactoryPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DesignPatterns;
using DesignPatterns_Strategy;

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
            //DelegateConsumer.ChangeNameInGradeBook();
            //var threadTestClass = new ThreadTestClass();
            //threadTestClass.TestThread();
            //threadTestClass.TestThreadWithJoin();

            //var singleton = Singleton.GetInstance;
            //var another = Singleton.GetInstance;
            //var bridgeclient = new DesignPatterns.BridgeClientConsumer();
            //bridgeclient.DesignRoom();

            //LinkedList.SimpleLinkedNodes();

            //MSInterview.IntegerToString();
            //var result = BigONotation.IsFirstElementNull(new List<string>() { "value1", "Value2", "Value3" });
            //result = BigONotation.ContainsValue(new List<string>() { "value1", "Value2", "Value3" }, "Value2");
            //result = BigONotation.ContainsDuplicates(new List<string>() { "value1", "Value2", "Value3" });
            //var fibResult = BigONotation.Fibonacci(4);
            //var client = new DesignPatterns_Strategy.EngineAssemblyCodeSmellConsumer();
            //client.AssemblyEngine(DesignPatterns_Strategy.EngineType.BMW);
            //var BMW = new BMW();
            //var Ford = new Ford();
            //var Sub = new Subaru();

            //var client = new EngineAssemblyUsingStrategyPatternConsumer(BMW);
            //client.AssembleEngine();

            //client = new EngineAssemblyUsingStrategyPatternConsumer(Ford);
            //client.AssembleEngine();

            //client = new EngineAssemblyUsingStrategyPatternConsumer(Sub);
            //client.AssembleEngine();

            var bTree = new AlgorithmsPractice.BinaryTree();
            bTree.Add(10);
            bTree.Add(5);
            bTree.Add(12);
            bTree.Add(23);
            bTree.Add(4);
            bTree.Add(9);
            bTree.Add(11);
            bTree.Add(8);   
            bTree.Add(16);
            bTree.Add(1);

            //var findValue = bTree.FindNode(34);
            //bTree.Visit()
            bool exists = bTree.Contains(9);
            //bTree.PreOrderTraversal();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSortmeth();

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
            var s = "this is a string to reverse";
            var len = s.Length;

            for (int i = 0; i = 10; i++)
            {

            }
        }
        
    }
}

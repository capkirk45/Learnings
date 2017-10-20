﻿using System;
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
            ReverseStringArray("this is a string to reverse");
            ReverseString();
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
        
    }
}

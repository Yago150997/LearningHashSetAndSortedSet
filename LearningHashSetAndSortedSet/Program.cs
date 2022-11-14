using System;
using System.Collections.Generic;

namespace LearningHashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int> {1, 3, 5, 7, 9, 11, };
            SortedSet<int> b = new SortedSet<int> { 2, 4, 6, 8, 10, 12 };

            a.UnionWith(b);
            foreach(int n in a)

            {
                Console.Write(n);
                Console.Write(" ");
            }
           
        }
    }
}

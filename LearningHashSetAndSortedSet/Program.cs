using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace LearningHashSetAndSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int> {1, 2, 3, 4, 5, 7, 9, 11, };
            SortedSet<int> b = new SortedSet<int> { 2, 4, 6, 8, 9, 10, 12, 13 };

            a.UnionWith(b); //Union
            PrintCollection(a);

            SortedSet<int> c = new SortedSet<int>(a);
            c.IntersectWith(b); //Intersection
            PrintCollection(c);

            SortedSet<int> d = new SortedSet<int>(a);
            d.ExceptWith(b); //Difference
            PrintCollection(d);


            static void PrintCollection<T>(IEnumerable<T> Collection)
            {
                foreach (T obj in Collection)
                {
                    Console.Write(obj + ", ");
                }

                Console.WriteLine();
            }
           
        }
    }
}

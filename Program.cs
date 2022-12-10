using System;
using System.Diagnostics;
using lab10;

namespace lab11
{
    class Program
    {
        static Stopwatch sw = new Stopwatch();
        static int n = 1000;
        static TestCollections tc = new TestCollections(n);


        static void Find(SchoolBook toFind)
        {
            sw.Start();
            tc.TKeyCollection1.Contains(toFind.Base);
            sw.Stop();
            Console.WriteLine(
                $"TKeyCollection1   (Contains):      {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            tc.StringCollection1.Contains(toFind.Base.ToString());
            sw.Stop();
            Console.WriteLine(
                $"StringCollection1 (Contains):      {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            tc.TKeyCollection2.ContainsKey(toFind.Base);
            sw.Stop();
            Console.WriteLine(
                $"TKeyCollection2   (ContainsKey):   {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            tc.StringCollection2.ContainsKey(toFind.Base.ToString());
            sw.Stop();
            Console.WriteLine(
                $"StringCollection2 (ContainsKey):   {sw.Elapsed}");
            sw.Reset();

            sw.Start();
            tc.StringCollection2.ContainsValue(toFind);
            sw.Stop();
            Console.WriteLine(
                $"StringCollection2 (ContainsValue): {sw.Elapsed}");
            sw.Reset();
        }


        static void Main()
        {
            Console.WriteLine("First element: \n");
            SchoolBook b1 = tc.constructor[0];
            Find((SchoolBook)b1.Clone());

            Console.WriteLine("\n\nLast element: \n");
            SchoolBook b2 = tc.constructor[n - 1];
            Find((SchoolBook)b2.Clone());

            Console.WriteLine("\n\nCenter element: \n");
            SchoolBook b3 = tc.constructor[n / 2 - 1];
            Find((SchoolBook)b3.Clone());

            Console.WriteLine("\n\nNon-existing element: \n");
            SchoolBook b4 = new SchoolBook();
            Find((SchoolBook)b4.Clone());
        }
    }
}
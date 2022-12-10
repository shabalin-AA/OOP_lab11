using System;
using lab10;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace lab11
{
    public class TestCollections
    {
        public SchoolBook[] constructor;


        public List<Book> TKeyCollection1;
        public List<string> StringCollection1;

        public SortedDictionary<Book, SchoolBook> TKeyCollection2;
        public SortedDictionary<string, SchoolBook> StringCollection2;


        public TestCollections(int n)
        {
            TKeyCollection1 = new List<Book>(n);
            StringCollection1 = new List<string>(n);
            TKeyCollection2 = new SortedDictionary<Book, SchoolBook>(new PrintingComparer());
            StringCollection2 = new SortedDictionary<string, SchoolBook>();

            constructor = new SchoolBook[n];
            for (int i = 0; i < n; i++)
            {
                SchoolBook sb;
                do { sb = new SchoolBook(); }
                while (!StringCollection2.TryAdd(sb.Base.ToString(), sb));

                constructor[i] = sb;
                TKeyCollection1.Add(sb.Base);
                StringCollection1.Add(sb.Base.ToString());
                TKeyCollection2.Add(sb.Base, sb);
            }
        }


        public void add(SchoolBook sb)
        {
            TKeyCollection1.Add(sb.Base);
            StringCollection1.Add(sb.Base.ToString());
            TKeyCollection2.Add(sb.Base, sb);
            StringCollection2.Add(sb.Base.ToString(), sb);
        }


        public void remove(SchoolBook sb)
        {
            TKeyCollection1.Remove(sb.Base);
            StringCollection1.Remove(sb.Base.ToString());
            TKeyCollection2.Remove(sb.Base);
            StringCollection2.Remove(sb.Base.ToString());
        }
    }
}


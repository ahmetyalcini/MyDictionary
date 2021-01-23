using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictonary = new MyDictionary<string, int>();

            dictonary.Add("Ahmet", 1);
            dictonary.Add("Selin", 2);
            dictonary.Add("Oğuz", 3);
            Console.WriteLine(dictonary.Count);
            Console.ReadKey();
        }
    }
}

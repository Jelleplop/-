using System;
using System.Collections.Generic;

namespace Dinamic 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> one = new List<short>() { 1, 0, 57, 97 };
            one.Add(21);
            one.AddRange(new short[] { 83, 53, 11});
            one.Insert(1, 107);
            one.Remove(0);
            one.RemoveAt(2);
            one.Sort();

            Console.WriteLine(one[2]);



        }
    }
}

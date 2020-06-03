using System;
using System.Linq; 

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
          string[]  arr = new string[] { "abcd", "abc" ,"a",  "ab" ,"\"zzz", "\"b" };

            var s2l = arr.OrderBy(i => i.Length).ToList();
            var l2s = arr.OrderByDescending(i => i.Length).ToList();
            var fst = arr.OrderBy(i => i.Substring(0, 1)).ToList();
            var quoteFst = arr.Where(i => i.Substring(0, 1) == "\"").Concat(arr.Where(i => i.Substring(0, 1) != "\"")).ToList();

            s2l.ForEach(i => Console.Write(i + ","));
            Console.WriteLine();
            string  l2sToPrint =  l2s.Aggregate((a,b) =>  a  + "," + b);
            Console.WriteLine(l2sToPrint);
            fst.ForEach(i => Console.Write(i + ","));
            Console.WriteLine();
            quoteFst.ForEach(i => Console.Write(i + ","));
            Console.WriteLine();
         }
    }
}
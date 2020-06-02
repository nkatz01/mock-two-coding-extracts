using System;

namespace Q3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var c = Complex.FromPolar(1, 45);
            // ...
            Console.WriteLine(c);
            
            c = Complex.FromCartesian(5, 6);
            
            Console.WriteLine(c);
        }
    }
}
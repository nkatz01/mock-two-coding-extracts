using System;

namespace Q6
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var context = new Transportation(new Taxi());
            context.Access();
            
            context = new Transportation(new Bus());
            context.Access();
        }
    }
}
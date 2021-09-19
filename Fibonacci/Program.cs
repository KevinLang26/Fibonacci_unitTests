using System;
using Fibonacci;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Genfib fib = new Genfib();
            int n = 10;
            var result = fib.Generate(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

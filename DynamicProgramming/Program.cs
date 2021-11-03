using System;
using DynamicProgramming;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci recursive");
            Console.WriteLine(FibonacciRecursive.Fibonacci(6));
            Console.WriteLine(FibonacciRecursive.Fibonacci(8));
            //Console.WriteLine(FibonacciRecursive.Fibonacci(50));

            Console.WriteLine("\n ******************************* \n");

            Console.WriteLine("Fibonacci with memoization");
            Console.WriteLine(FibonacciRecursiveMemoization.Fibonacci(6));
            Console.WriteLine(FibonacciRecursiveMemoization.Fibonacci(8));
            Console.WriteLine(FibonacciRecursiveMemoization.Fibonacci(50));

            Console.WriteLine("\n ******************************* \n");

            Console.WriteLine("Fibonacci with tabulation");
            Console.WriteLine(FibonacciTabulation.Fibonacci(6));
            Console.WriteLine(FibonacciTabulation.Fibonacci(8));
            Console.WriteLine(FibonacciTabulation.Fibonacci(50));
        }
    }
}

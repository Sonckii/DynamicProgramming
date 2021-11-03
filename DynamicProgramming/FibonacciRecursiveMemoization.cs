using System.Collections.Generic;

namespace DynamicProgramming
{
    public class FibonacciRecursiveMemoization
    {
        private static readonly Dictionary<int, long> Memo = new Dictionary<int, long>()
        {
            {0, 0},
            {1, 1}
        };

        public static long Fibonacci(int n)
        {
            if (Memo.ContainsKey(n)) return Memo[n];

            var fibN = Fibonacci(n - 1) + Fibonacci(n - 2);
            Memo.Add(n, fibN);
            return Memo[n];
        }
    }
}
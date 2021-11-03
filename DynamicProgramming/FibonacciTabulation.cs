namespace Fibonacci
{
    public static class FibonacciTabulation
    {
        
        public static long Fibonacci(int n)
        {
            long[] table = new long[n + 2];
            table[1] = 1;

            for (int i = 0; i <= n; i++)
            {
                table[i + 1] += table[i];
                if (i + 2 >= table.Length) continue;
                table[i + 2] += table[i];
            }

            return table[n];
        }
    }
}
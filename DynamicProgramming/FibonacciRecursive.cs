namespace Fibonacci
{
    public class FibonacciRecursive
    {
        public static long Fibonacci(int n)
        {
            //Console.WriteLine("Loop");
            if (n <= 2)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
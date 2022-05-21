using System;

namespace BigO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            //f(n) = n, O(f(n)) = O(n)
            for (int i = 0; i < n;)
                i++;

            //f(n) = n/3, O(f(n)) = O(n)
            for (int i = 0; i < n;)
                i += 3;

            //f(n) = n*n, O(f(n)) = O(n^2)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n;)
                    j++;
            }

            //f(n) = n*(n/3), O(f(n)) = O(n^2)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n;)
                    j += 3;
            }

            //f(n) = n*(n/2 * (n-1)), O(f(n)) = O(n^2)
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n;)
                {
                    j++;
                }
            }
        }
    }
}
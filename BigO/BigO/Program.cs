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

            Console.WriteLine(BinarySearch(new[] { 1, 3, 5, 7, 9, 11, 33, 55, 77, 99, 123 }, 77));
        }

        //f(n) = n/2 + n/4 + n/8 .... O(f(n)) = O(log(n))
        static bool BinarySearch(int[] arr, int valueToFind)
        {
            int lowIndex = 0;
            int highIndex = arr.Length - 1;

            while (lowIndex < highIndex)
            {
                int midIndex = (lowIndex + highIndex) / 2;

                if (arr[midIndex] == valueToFind)
                    return true;

                if (arr[midIndex] > valueToFind)
                    highIndex = midIndex - 1;
                else if (arr[midIndex] < valueToFind)
                    lowIndex = midIndex + 1;
            }

            return false;
        }
    }
}
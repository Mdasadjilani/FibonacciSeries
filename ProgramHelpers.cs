using System;

namespace FibonacciSeries
{
    internal static class ProgramHelpers
    {
        public static void FindSeries(int n)
        {
            int first = 0;
            int second = 1;
            int sum = 0;

            for (int i = 2; i < n; i++)
            {
                sum = first + second;
                Console.Write(" {0}", sum);
                first = second;
                second = sum;
            }
        }
    }
}
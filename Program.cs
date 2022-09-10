using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
            int numb = Convert.ToInt32(Console.ReadLine());
            FindSeries(numb);
        }
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

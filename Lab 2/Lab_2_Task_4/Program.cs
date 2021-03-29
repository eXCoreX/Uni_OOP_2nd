using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_4
{
    class Program
    {
        static double Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Can't find factorial of negative value.");
            }
            double res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Series 1 (1/2^n, n_0 = 0):");
            Console.WriteLine(InfiniteSeriesCalculator.Calculate(i => 1 / Math.Pow(2, i), 0, 0.01));
            Console.WriteLine("Series 2 (1/n!, n_0 = 1):");
            Console.WriteLine(InfiniteSeriesCalculator.Calculate(i => 1 / Factorial(i), 1, 0.01));
            Console.WriteLine("Series 3 (1 + (-1)^n/2^(n+1), n_0 = 0):");
            Console.WriteLine(1 + InfiniteSeriesCalculator.Calculate(i => Math.Pow(-1, i) / Math.Pow(2, i + 1), 0, 0.01));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

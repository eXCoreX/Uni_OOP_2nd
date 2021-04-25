using System;

namespace Lab_2_Task_4
{
    class InfiniteSeriesCalculator
    {
        public static double Calculate(Func<int, double> nthTerm, int n_0 = 0, double eps = 1e-7, int maxIter = 10_000)
        {
            double res = 0;
            int n = n_0;
            int iter = 0;
            double currentEps;
            do
            {
                double newRes = res + nthTerm(n);
                n++;
                iter++;
                currentEps = res - newRes;
                res = newRes;
            } while (Math.Abs(currentEps) > eps && iter < maxIter);

            return res;
        }
    }
}

using System;

namespace LeetCode.Recursion_I._4_ComplexityAnalysis
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/256/complexity-analysis/2380/
    /// </summary>
    public static class Pow
    {
        public static double MyPow(double x, int n)
        {
            const double minLimit = 0.00001;
            const double maxLimit = double.MaxValue;
            var result = GetPow(Math.Abs(x), n);
            return x < 0 && n % 2 != 0 ? -result : result;

            double GetPow(double x, int n)
            {
                if (n == 0)
                    return 1;

                if (x == 1)
                    return 1;

                if (n == int.MinValue)
                    return 0;
                
                return n > 0 ? Multiply(x, n) : 1 / Multiply(x, Math.Abs(n));
            }

            double Multiply(double x, int n)
            {
                if (Math.Abs(x) <= minLimit)
                    return 0;

                if (Math.Abs(x) >= maxLimit - minLimit)
                    return maxLimit;
                
                if (n == 0)
                    return 1;

                var res = x * Multiply(x, n - 1);
                return res;
            }
        }
    }
}
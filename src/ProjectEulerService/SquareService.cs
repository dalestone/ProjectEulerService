using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerService
{
    public class SquareService
    {
        public int SumOfSquares(int n)
        {
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }

            return sum;
        }

        public int SquareOfSum(int n)
        {
            var sum = 0;
            var sumSquared = 0;

            for (var i = 1; i <= n; i++)
            {
                sum += i;
            }

            sumSquared = (int)Math.Pow(sum, 2);

            return sumSquared;
        }

        public int SumSquareDifference(int n)
        {
            return SquareOfSum(n) - SumOfSquares(n);
        }
    }
}
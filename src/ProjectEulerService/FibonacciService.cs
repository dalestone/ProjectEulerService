using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ProjectEulerService.Services
{
    public class FibonacciService
    {
        public IEnumerable<T> FibonacciNumbers<T>(int limit)
        {
            var fiboNums = new List<T>();

            for (int a = 1, b = 2, c = 0, i = 3; i <= limit; i++)
            {
                if (i == 3)
                {
                    fiboNums.Add((T)Convert.ChangeType(a, typeof(T)));
                    fiboNums.Add((T)Convert.ChangeType(b, typeof(T)));
                }

                c = a + b;
                a = b;
                b = c;

                fiboNums.Add((T)Convert.ChangeType(c, typeof(T)));
            }

            return fiboNums;
        }

        public IEnumerable<T> FibonacciNumbers<T>(int limit, int exceedValue)
        {
            var fiboNums = new List<T>();

            for (int a = 1, b = 2, c = 0, i = 3; i <= limit; i++)
            {
                if (c >= exceedValue)
                    break;

                if (i == 3)
                {
                    fiboNums.Add((T)Convert.ChangeType(a, typeof(T)));
                    fiboNums.Add((T)Convert.ChangeType(b, typeof(T)));
                }

                c = a + b;
                a = b;
                b = c;

                fiboNums.Add((T)Convert.ChangeType(c, typeof(T)));
            }

            return fiboNums;
        }

        public IEnumerable<int> EvenFibonacciNumbers(IEnumerable<int> fiboNums)
        {
            return fiboNums.Where(n => n % 2 == 0).ToList();
        }

        public int IndexOfNthDigitFibonacciNumber(int digits)
        {
            BigInteger a = 1, b = 2, c = 0;
            int currentDigitLength = 0;
            int i = 3;

            while (currentDigitLength < digits)
            {
                c = a + b;
                a = b;
                b = c;

                currentDigitLength = Convert.ToString(c).Length;

                i++;
            }

            return i;
        }
    }
}

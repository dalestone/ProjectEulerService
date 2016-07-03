using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ProjectEulerService.Services
{
    public class FibonacciService
    {
        public IEnumerable<int> FibonacciNumbers(int limit)
        {
            var fiboNums = new List<int>();

            for (int a = 1, b = 2, c = 0, i = 3; i <= limit; i++)
            {
                if (i == 3)
                {
                    fiboNums.Add(a);
                    fiboNums.Add(b);
                }

                c = a + b;
                a = b;
                b = c;

                fiboNums.Add(c);
            }

            return fiboNums;
        }

        public IEnumerable<int> FibonacciNumbers(int limit, int exceedValue)
        {
            var fiboNums = new List<int>();

            for (int a = 1, b = 2, c = 0, i = 3; i <= limit; i++)
            {
                if (c >= exceedValue)
                    break;

                if (i == 3)
                {
                    fiboNums.Add(a);
                    fiboNums.Add(b);
                }

                c = a + b;
                a = b;
                b = c;

                fiboNums.Add(c);
            }

            return fiboNums;
        }

        public IEnumerable<int> EvenFibonacciNumbers(IEnumerable<int> fiboNums)
        {
            return fiboNums.Where(n => n % 2 == 0).ToList();
        }
    }
}

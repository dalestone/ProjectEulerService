﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerService.Services
{
    public class MultipleService
    {
        public int SumMultiples(int a, int b, int limit)
        {
            int sum = 0;

            for (var i = 1; i < limit; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        //TODO: create an overload for sum multiples that allows a list of multiples to be passed

        public void SmallestMultiple(int limit)
        {

        }
    }
}

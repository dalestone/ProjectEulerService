using ProjectEulerService.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectEulerServices.Tests
{
    public class MultipleServiceTests
    {
        private readonly MultipleService _multipleService;

        public MultipleServiceTests()
        {
            _multipleService = new MultipleService();   
        }

        [Fact]
        public void ReturnSumGivenMultiples()
        {
            Assert.Equal(233168, _multipleService.SumMultiples(3, 5, 1000));
        }

        [Fact]
        public void ReturnSmallestPositiveNumberEvenlyDivisbleGivenLimit()
        {

        }
    }
}

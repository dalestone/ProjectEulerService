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
            var expected = 23;
            var limit = 10;
            var multiples = new List<int> { 3, 5 };
            var actual = _multipleService.SumMultiples(multiples[0], multiples[1], limit);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSmallestPositiveNumberEvenlyDivisbleGivenLimit()
        {

        }

        [Fact]
        public void ReturnProjectEulerProblem1Answer()
        {
            var expected = 233168;
            var limit = 1000;
            var multiples = new List<int> { 3, 5 };
            var actual = _multipleService.SumMultiples(multiples[0], multiples[1], limit);

            Assert.Equal(expected, actual);
        }
    }
}

using ProjectEulerService.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ProjectEulerServices.Tests
{
    public class FibonacciServiceTests
    {
        private readonly FibonacciService _fibonacciService;

        public FibonacciServiceTests()
        {
            _fibonacciService = new FibonacciService();
        }

        [Fact]
        public void ReturnFibonacciNumbersGivenLimit()
        {
            var limit = 10;
            var expected = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };        
            var actual = _fibonacciService.FibonacciNumbers<int>(limit);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnEvenFibonacciNumbers()
        {
            var limit = 10;
            var expected = new List<int> { 2, 8, 34 };
            var actual = _fibonacciService.EvenFibonacciNumbers(_fibonacciService.FibonacciNumbers<int>(limit));

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnProjectEulerProblem2Answer()
        {
            var limit = 4000000;
            var exceed = limit;
            var expected = 4613732;
            var actual = _fibonacciService.EvenFibonacciNumbers(_fibonacciService.FibonacciNumbers<int>(limit, exceed)).Sum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnIndexOfFibonacciSequenceWithNDigits()
        {
            var digits = 3;
            var expected = 12;
            var actual = _fibonacciService.IndexOfNthDigitFibonacciNumber(digits);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnProjectEulerProblem25Answer()
        {
            var digits = 1000;
            var expected = 4782;
            var actual = _fibonacciService.IndexOfNthDigitFibonacciNumber(digits);

            Assert.Equal(expected, actual);
        }
    }
}

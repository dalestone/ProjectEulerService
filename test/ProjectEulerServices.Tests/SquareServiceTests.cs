using ProjectEulerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectEulerServices.Tests
{
    public class SquareServiceTests
    {
        private readonly SquareService _squareService;

        public SquareServiceTests()
        {
            _squareService = new SquareService();
        }

        [Fact]
        public void ReturnSumOfSquares()
        {
            var n = 10;
            var expected = 385;
            var actual = _squareService.SumOfSquares(n);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSquareOfSum()
        {
            var n = 10;
            var expected = 3025;
            var actual = _squareService.SquareOfSum(n);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSumSquareDifference()
        {
            var n = 10;
            var expected = 2640;
            var actual = _squareService.SumSquareDifference(n);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnProjectEulerProblem6Answer()
        {
            var n = 100;
            var expected = 25164150;
            var actual = _squareService.SumSquareDifference(n);

            Assert.Equal(expected, actual);
        }
    }
}

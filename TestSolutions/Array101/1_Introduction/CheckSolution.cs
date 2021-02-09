using FluentAssertions;
using LeetCode.Arrays101._1_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._1_Introduction
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void MaxConsecutiveOnesTest()
        {
            var input = new[] {1, 1, 0, 0, 1, 1, 1};
            var output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(3);

            input = new[] {1, 0, 0, 0, 1, 1, 0};
            output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(2);

            input = new[] {1};
            output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(1);

            input = new[] {0};
            output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(0);
        }

        [TestMethod]
        public void FindNumbersWithEvenNumberOfDigitsTest()
        {
            var input = new[] {12, 345, 2, 6, 7896};
            var output = FindNumbersWithEvenNumberOfDigits.FindNumbers(input);
            output.Should().Be(2);

            input = new[] {555, 901, 482, 1771};
            output = FindNumbersWithEvenNumberOfDigits.FindNumbers(input);
            output.Should().Be(1);
        }
        
        [TestMethod]
        public void SquaresOfASortedArrayTest()
        {
            var input = new[] {-4, -1, 0, 3, 10};
            var output = SquaresOfASortedArray.SortedSquares(input);
            output.Should().ContainInOrder(new [] {0, 1, 9, 16, 100});

            input = new[] {-7, -3, 2, 3, 11};
            output = SquaresOfASortedArray.SortedSquares(input);
            output.Should().ContainInOrder(new [] {4, 9, 9, 49, 121});
        }
    }
}
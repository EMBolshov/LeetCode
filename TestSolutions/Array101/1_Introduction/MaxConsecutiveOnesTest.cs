using FluentAssertions;
using LeetCode.Arrays101._1_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._1_Introduction
{
    [TestClass]
    public class MaxConsecutiveOnesTest
    {
        [TestMethod]
        public void MaxConsecutiveOnesTestCase1()
        {
            var input = new[] {1, 1, 0, 0, 1, 1, 1};
            var output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(3);
        }

        [TestMethod]
        public void MaxConsecutiveOnesTestCase2()
        {
            var input = new[] {1, 0, 0, 0, 1, 1, 0};
            var output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(2);
        }

        [TestMethod]
        public void MaxConsecutiveOnesTestCase3()
        {
            var input = new[] {1};
            var output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(1);
        }

        [TestMethod]
        public void MaxConsecutiveOnesTestCase4()
        {
            var input = new[] {0};
            var output = MaxConsecutiveOnes.FindMaxConsecutiveOnes(input);
            output.Should().Be(0);
        }
    }
}
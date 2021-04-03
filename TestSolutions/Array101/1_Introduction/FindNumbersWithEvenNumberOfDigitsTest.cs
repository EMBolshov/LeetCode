using FluentAssertions;
using LeetCode.Arrays101._1_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._1_Introduction
{
    [TestClass]
    public class FindNumbersWithEvenNumberOfDigitsTest
    {
        [TestMethod]
        public void FindNumbersWithEvenNumberOfDigitsTestCase1()
        {
            var input = new[] {12, 345, 2, 6, 7896};
            var output = FindNumbersWithEvenNumberOfDigits.FindNumbers(input);
            output.Should().Be(2);
        }
        
        [TestMethod]
        public void FindNumbersWithEvenNumberOfDigitsTestCase2()
        {
            var input = new[] {555, 901, 482, 1771};
            var output = FindNumbersWithEvenNumberOfDigits.FindNumbers(input);
            output.Should().Be(1);
        }
    }
}
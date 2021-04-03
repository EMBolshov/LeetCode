using FluentAssertions;
using LeetCode.Arrays101._5_InPlaceOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._5_InPlaceOperations
{
    [TestClass]
    public class MoveZeroesInPlaceTest
    {
        [TestMethod]
        public void MoveZeroesInPlaceTestCase1()
        {
            var testData = new[] {0, 1, 0, 3, 12};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {1, 3, 12, 0, 0});
        }

        [TestMethod]
        public void MoveZeroesInPlaceTestCase2()
        {
            var testData = new[] {0};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {0});
        }

        [TestMethod]
        public void MoveZeroesInPlaceTestCase3()
        {
            var testData = new[] {0, 0, 1};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {1, 0, 0});
        }
    }
}
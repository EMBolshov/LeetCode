using FluentAssertions;
using LeetCode.Arrays101._2_InsertingItemsIntoAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._2_InsertingItemsIntoAnArray
{
    [TestClass]
    public class DuplicateZeroesTest
    {
        [TestMethod]
        public void DuplicateZeroesTestCase1()
        {
            var testData = new[] {1, 0, 2, 3, 0, 4, 5, 0};
            DuplicateZeroes.DuplicateZeros(testData);
            testData.Should().ContainInOrder(new [] {1, 0, 0, 2, 3, 0, 0, 4});
        }
        
        [TestMethod]
        public void DuplicateZeroesTestCase2()
        {
            var testData = new[] {1, 2, 3};
            DuplicateZeroes.DuplicateZeros(testData);
            testData.Should().ContainInOrder(new [] {1, 2, 3});
        }
    }
}
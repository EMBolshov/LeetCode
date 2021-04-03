using FluentAssertions;
using LeetCode.Arrays101._3_DeletingItemsFromArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._3_DeletingItemsFromArray
{
    [TestClass]
    public class RemoveElementTest
    {
        [TestMethod]
        public void RemoveElementTestCase1()
        {
            var testData = new[] {3, 2, 2, 3};
            var result = RemoveElementInPlace.RemoveElement(testData, 3);
            result.Should().Be(2);
            testData.Should().StartWith(new[] {2, 2});
        }
        
        [TestMethod]
        public void RemoveElementTestCase2()
        {
            var testData = new[] {0, 1, 2, 2, 3, 0, 4, 2};
            var result = RemoveElementInPlace.RemoveElement(testData, 2);
            result.Should().Be(5);
            testData.Should().StartWith(new[] {0, 1, 3, 0, 4});
        }
    }
}
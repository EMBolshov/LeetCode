using FluentAssertions;
using LeetCode.Arrays101._3_DeletingItemsFromArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._3_DeletingItemsFromArray
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayTestCase1()
        {
            var testData = new[] {1, 1, 2};
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(testData);
            result.Should().Be(2);
            testData.Should().StartWith(new[] {1, 2});
        }
        
        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayTestCase2()
        {
            var testData = new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(testData);
            result.Should().Be(5);
            testData.Should().StartWith(new[] {0, 1, 2, 3, 4});
        }
    }
}
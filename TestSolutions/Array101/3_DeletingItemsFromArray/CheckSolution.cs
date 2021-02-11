using FluentAssertions;
using LeetCode.Arrays101._3_DeletingItemsFromArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._3_DeletingItemsFromArray
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayTest()
        {
            var testData = new[] {1, 1, 2};
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(testData);
            result.Should().Be(2);
            testData.Should().StartWith(new[] {1, 2});

            testData = new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(testData);
            result.Should().Be(5);
            testData.Should().StartWith(new[] {0, 1, 2, 3, 4});
        }

        [TestMethod]
        public void RemoveElementTest()
        {
            var testData = new[] {3, 2, 2, 3};
            var result = RemoveElementInPlace.RemoveElement(testData, 3);
            result.Should().Be(2);
            testData.Should().StartWith(new[] {2, 2});

            testData = new[] {0, 1, 2, 2, 3, 0, 4, 2};
            result = RemoveElementInPlace.RemoveElement(testData, 2);
            result.Should().Be(5);
            testData.Should().StartWith(new[] {0, 1, 3, 0, 4});
        }
    }
}
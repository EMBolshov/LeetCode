using FluentAssertions;
using LeetCode.Arrays101._2_InsertingItemsIntoAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._2_InsertingItemsIntoAnArray
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void DuplicateZeroesTest()
        {
            var testData = new[] {1, 0, 2, 3, 0, 4, 5, 0};
            DuplicateZeroes.DuplicateZeros(testData);
            testData.Should().ContainInOrder(new [] {1, 0, 0, 2, 3, 0, 0, 4});

            testData = new[] {1, 2, 3};
            DuplicateZeroes.DuplicateZeros(testData);
            testData.Should().ContainInOrder(new [] {1, 2, 3});
        }

        [TestMethod]
        public void MergeSortedArrayTest()
        {
            var nums1 = new[] {1, 2, 3, 0, 0, 0};
            var m = 3;
            var nums2 = new[] {2, 5, 6};
            var n = 3;
            MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.Should().ContainInOrder(new [] {1, 2, 2, 3, 5, 6});

            nums1 = new[] {1};
            m = 1;
            nums2 = new int[] {};
            n = 0;
            MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.Should().ContainInOrder(new [] {1});
        }
    }
}
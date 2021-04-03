using FluentAssertions;
using LeetCode.Arrays101._2_InsertingItemsIntoAnArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._2_InsertingItemsIntoAnArray
{
    [TestClass]
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void MergeSortedArrayTestCase1()
        {
            var nums1 = new[] {1, 2, 3, 0, 0, 0};
            var m = 3;
            var nums2 = new[] {2, 5, 6};
            var n = 3;
            MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.Should().ContainInOrder(new [] {1, 2, 2, 3, 5, 6});
        }
        
        [TestMethod]
        public void MergeSortedArrayTestCase2()
        {
            var nums1 = new[] {1};
            var m = 1;
            var nums2 = new int[] {};
            var n = 0;
            MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.Should().ContainInOrder(new [] {1});
        }
    }
}
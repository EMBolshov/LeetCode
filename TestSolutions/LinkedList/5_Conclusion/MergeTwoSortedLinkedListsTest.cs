using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._5_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._5_Conclusion
{
    [TestClass]
    public class MergeTwoSortedLinkedListsTest
    {
        [TestMethod]
        public void MergeTwoListsTestCase1()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 4});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {1, 3, 4});
            var output = MergeTwoSortedLinkedLists.MergeTwoLists(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 1, 2, 3, 4, 4}).Should().BeTrue();
        }
        
        [TestMethod]
        public void MergeTwoListsTestCase2()
        {
            var output = MergeTwoSortedLinkedLists.MergeTwoLists(null, null);
            output.Should().BeNull();
        }
        
        [TestMethod]
        public void MergeTwoListsTestCase3()
        {
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {0});
            var output = MergeTwoSortedLinkedLists.MergeTwoLists(null, list2).ValuesToFlatList();
            output.SequenceEqual(new [] {0}).Should().BeTrue();
        }
        
        [TestMethod]
        public void MergeTwoListsTestCase4()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 4, 5, 6, 7});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {1, 3, 4});
            var output = MergeTwoSortedLinkedLists.MergeTwoLists(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 1, 2, 3, 4, 4, 5, 6, 7}).Should().BeTrue();
        }
    }
}
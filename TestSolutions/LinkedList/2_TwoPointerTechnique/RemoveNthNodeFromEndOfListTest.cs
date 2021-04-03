using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class RemoveNthNodeFromEndOfListTest
    {
        [TestMethod]
        public void RemoveNthNodeFromEndOfListTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            var output = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 2, 3, 5}).Should().BeTrue();
        }
        
        [TestMethod]
        public void RemoveNthNodeFromEndOfListTestCase2()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            var output = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList();
            output.SequenceEqual(new[] {2}).Should().BeTrue();
        }
        
        [TestMethod]
        public void RemoveNthNodeFromEndOfListTestCase3()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            var output = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 1).ValuesToFlatList();
            output.SequenceEqual(new[] {1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void RemoveNthNodeFromEndOfListTestCase4()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3});
            var output = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 3}).Should().BeTrue();
        }
        
        [TestMethod]
        public void RemoveNthNodeFromEndOfListTestCase5()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3});
            var output = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 3).ValuesToFlatList();
            output.SequenceEqual(new[] {2, 3}).Should().BeTrue();
        }
    }
}
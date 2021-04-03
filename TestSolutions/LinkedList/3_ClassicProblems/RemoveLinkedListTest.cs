using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class RemoveLinkedListTest
    {
        [TestMethod]
        public void RemoveLinkedListTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 6, 3, 4, 5, 6});
            var output = RemoveLinkedListElements.RemoveElements(list, 6).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 2, 3, 4, 5}).Should().BeTrue();
        }
        
        [TestMethod]
        public void RemoveLinkedListTestCase2()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {7, 7, 7, 7});
            RemoveLinkedListElements.RemoveElements(list, 7).ValuesToFlatList().Should().BeEquivalentTo(new List<int>());
        }
        
        [TestMethod]
        public void RemoveLinkedListTestCase3()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 2, 1});
            RemoveLinkedListElements.RemoveElements(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 1
            });
        }
    }
}
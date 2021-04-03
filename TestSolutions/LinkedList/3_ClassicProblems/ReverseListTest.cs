using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class ReverseListTest
    {
        [TestMethod]
        public void ReverseListTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            var output = ReverseLinkedList.ReverseList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {5, 4, 3, 2, 1}).Should().BeTrue();
        }
    }
}
using System.Collections.Generic;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void ReverseListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            ReverseLinkedList.ReverseList(list).ToFlatList().Should().BeEquivalentTo(new List<int>
            {
                5, 4, 3, 2, 1
            });
        }
    }
}
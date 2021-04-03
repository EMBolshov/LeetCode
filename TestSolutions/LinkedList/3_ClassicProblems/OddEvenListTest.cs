using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class OddEvenListTest
    {
        [TestMethod]
        public void OddEvenListTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            var output = OddEvenLinkedList.OddEvenList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 3, 5, 2, 4}).Should().BeTrue();
        }
        
        [TestMethod]
        public void OddEvenListTestCase2()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5, 6, 7, 8});
            var output = OddEvenLinkedList.OddEvenList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 3, 5, 7, 2, 4, 6, 8}).Should().BeTrue();
        }
    }
}
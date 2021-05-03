using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._5_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._5_Conclusion
{
    [TestClass]
    public class AddTwoNumbersFromLinkedListTest
    {
        [TestMethod]
        public void AddTwoNumbersTestCase1()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[] {2, 4, 3});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {5, 6, 4});
            var output = AddTwoNumbersFromLinkedLists.AddTwoNumbers(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[] {7, 0, 8}).Should().BeTrue();
        }

        [TestMethod]
        public void AddTwoNumbersTestCase2()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[] {0});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {0});
            var output = AddTwoNumbersFromLinkedLists.AddTwoNumbers(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[] {0}).Should().BeTrue();
        }

        [TestMethod]
        public void AddTwoNumbersTestCase3()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[] {9, 9, 9, 9, 9, 9, 9});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {9, 9, 9, 9});
            var output = AddTwoNumbersFromLinkedLists.AddTwoNumbers(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[] {8, 9, 9, 9, 0, 0, 0, 1}).Should().BeTrue();
        }

        [TestMethod]
        public void AddTwoNumbersTestCase4()
        {
            var list1 = CommonHelpers.GetLinkedListFromArray(new[]
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1});
            var list2 = CommonHelpers.GetLinkedListFromArray(new[] {5, 6, 4});
            var output = AddTwoNumbersFromLinkedLists.AddTwoNumbers(list1, list2).ValuesToFlatList();
            output.SequenceEqual(new[]
                    {6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1})
                .Should().BeTrue();
        }
    }
}
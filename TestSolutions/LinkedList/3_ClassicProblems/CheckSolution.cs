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
    public class CheckSolution
    {
        [TestMethod]
        public void ReverseListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            var output = ReverseLinkedList.ReverseList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {5, 4, 3, 2, 1}).Should().BeTrue();
        }

        [TestMethod]
        public void RemoveLinkedListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 6, 3, 4, 5, 6});
            var output = RemoveLinkedListElements.RemoveElements(list, 6).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 2, 3, 4, 5}).Should().BeTrue();

            list = CommonHelpers.GetLinkedListFromArray(new[] {7, 7, 7, 7});
            RemoveLinkedListElements.RemoveElements(list, 7).ValuesToFlatList().Should().BeEquivalentTo(new List<int>());
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 2, 1});
            RemoveLinkedListElements.RemoveElements(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 1
            });

        }
        
        [TestMethod]
        public void OddEvenListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            var output = OddEvenLinkedList.OddEvenList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 3, 5, 2, 4}).Should().BeTrue();
          
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5, 6, 7, 8});
            output = OddEvenLinkedList.OddEvenList(list).ValuesToFlatList();
            output.SequenceEqual(new[] {1, 3, 5, 7, 2, 4, 6, 8}).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPalindromeListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 2, 1});
            PalindromeLinkedList.IsPalindrome(list).Should().BeTrue();
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            PalindromeLinkedList.IsPalindrome(list).Should().BeFalse();
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 1, 2, 1});
            PalindromeLinkedList.IsPalindrome(list).Should().BeFalse();
        }
    }
}
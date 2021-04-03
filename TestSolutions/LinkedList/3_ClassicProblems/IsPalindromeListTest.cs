using FluentAssertions;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class IsPalindromeListTest
    {
        [TestMethod]
        public void IsPalindromeListTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 2, 1});
            PalindromeLinkedList.IsPalindrome(list).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPalindromeListTestCase2()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            PalindromeLinkedList.IsPalindrome(list).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsPalindromeListTestCase3()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 1, 2, 1});
            PalindromeLinkedList.IsPalindrome(list).Should().BeFalse();
        }
    }
}
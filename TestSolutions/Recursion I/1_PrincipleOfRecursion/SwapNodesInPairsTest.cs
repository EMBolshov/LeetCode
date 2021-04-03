using System.Linq;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.Recursion_I._1_PricipleOfRecursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.Recursion_I._1_PrincipleOfRecursion
{
    [TestClass]
    public class SwapNodesInPairsTest
    {
        [TestMethod]
        public void SwapNodesInPairsTestCase1()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4});
            var result = SwapNodesInPairs.SwapPairs(list).ValuesToFlatList();
            result.SequenceEqual(new[] {2, 1, 4, 3}).Should().BeTrue();
        }
        
        [TestMethod]
        public void SwapNodesInPairsTestCase2()
        {
            var result = SwapNodesInPairs.SwapPairs(null);
            result.Should().BeNull();
        }
        
        [TestMethod]
        public void SwapNodesInPairsTestCase3()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1});
            var result = SwapNodesInPairs.SwapPairs(list).ValuesToFlatList();
            result.SequenceEqual(new[] {1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void SwapNodesInPairsTestCase4()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3});
            var result = SwapNodesInPairs.SwapPairs(list).ValuesToFlatList();
            result.SequenceEqual(new[] {2, 1, 3}).Should().BeTrue();
        }
    }
}
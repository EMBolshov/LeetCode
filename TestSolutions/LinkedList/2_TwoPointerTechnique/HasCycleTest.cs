using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class HasCycleTest
    {
        [TestMethod]
        public void HasCycleTestCase1()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 2);
            LinkedListCycle.HasCycle(linkedList).Should().BeTrue();
        }
        
        [TestMethod]
        public void HasCycleTestCase2()
        {
            var linkedList = new MySinglyLinkedList(1); // No cycle
            LinkedListCycle.HasCycle(linkedList).Should().BeFalse();
        }
    }
}
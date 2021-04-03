using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class DetectCycleTest
    {
        [TestMethod]
        public void DetectCycleTestCase1()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 2);
            var cycleNode = linkedList.GetNodeAtIndex(2);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }
        
        [TestMethod]
        public void DetectCycleTestCase2()
        {
            var values = new[] {1, 2};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 0);
            var cycleNode = linkedList.GetNodeAtIndex(0);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }
        
        [TestMethod]
        public void DetectCycleTestCase3()
        {
            var linkedList = new MySinglyLinkedList(1); // No cycle
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeNull();
        }
        
        [TestMethod]
        public void DetectCycleTestCase4()
        {
            var values = new[] {-21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 24);
            var cycleNode = linkedList.GetNodeAtIndex(24);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }
        
        [TestMethod]
        public void DetectCycleTestCase5()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 1);
            var cycleNode = linkedList.GetNodeAtIndex(1);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }
        
        [TestMethod]
        public void DetectCycleTestCase6()
        {
            var values = new[] {-1, -7, 7, -4, 19, 6, -9, -5, -2, -5};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 6);
            var cycleNode = linkedList.GetNodeAtIndex(6);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }
    }
}
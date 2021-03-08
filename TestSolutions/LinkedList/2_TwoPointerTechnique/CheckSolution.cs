using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void HasCycleTest()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = GetCycledLinkedList(values, 2);

            LinkedListCycle.HasCycle(linkedList).Should().BeTrue();

            linkedList = new MyLinkedList(1); // No cycle
            LinkedListCycle.HasCycle(linkedList).Should().BeFalse();
        }

        [TestMethod]
        public void DetectCycleTest()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = GetCycledLinkedList(values, 2);
            var cycleNode = linkedList.GetElementAtIndex(2);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);


            values = new[] {1, 2};
            linkedList = GetCycledLinkedList(values, 0);
            cycleNode = linkedList.GetElementAtIndex(0);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);


            linkedList = new MyLinkedList(1); // No cycle
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeNull();


            //values = new[] {-21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5};
            //linkedList = GetCycledLinkedList(values, 24);
            //cycleNode = linkedList.GetElementAtIndex(24);
            //LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
            
            values = new[] {3, 2, 0, -4};
            linkedList = GetCycledLinkedList(values, 1);
            cycleNode = linkedList.GetElementAtIndex(1);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
            
            values = new[] {-1, -7, 7, -4, 19, 6, -9, -5, -2, -5};
            linkedList = GetCycledLinkedList(values, 6);
            cycleNode = linkedList.GetElementAtIndex(6);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }

        private MyLinkedList GetCycledLinkedList(int[] values, int cycleIndex)
        {
            var result = new MyLinkedList();

            foreach (var value in values)
            {
                result.AddAtTail(value);
            }

            var tail = result.GetTail();
            var cycleNode = result.GetElementAtIndex(cycleIndex);

            tail.Next = cycleNode;

            return result;
        }
    }
}
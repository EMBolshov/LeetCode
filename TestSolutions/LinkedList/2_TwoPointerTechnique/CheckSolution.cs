using System.Collections.Generic;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void HasCycleTest()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 2);
            LinkedListCycle.HasCycle(linkedList).Should().BeTrue();

            linkedList = new MySinglyLinkedList(1); // No cycle
            LinkedListCycle.HasCycle(linkedList).Should().BeFalse();
        }

        [TestMethod]
        public void DetectCycleTest()
        {
            var values = new[] {3, 2, 0, -4};
            var linkedList = CommonHelpers.GetCycledLinkedList(values, 2);
            var cycleNode = linkedList.GetNodeAtIndex(2);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);

            values = new[] {1, 2};
            linkedList = CommonHelpers.GetCycledLinkedList(values, 0);
            cycleNode = linkedList.GetNodeAtIndex(0);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);

            linkedList = new MySinglyLinkedList(1); // No cycle
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeNull();

            values = new[] {-21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5};
            linkedList = CommonHelpers.GetCycledLinkedList(values, 24);
            cycleNode = linkedList.GetNodeAtIndex(24);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
            
            values = new[] {3, 2, 0, -4};
            linkedList = CommonHelpers.GetCycledLinkedList(values, 1);
            cycleNode = linkedList.GetNodeAtIndex(1);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
            
            values = new[] {-1, -7, 7, -4, 19, 6, -9, -5, -2, -5};
            linkedList = CommonHelpers.GetCycledLinkedList(values, 6);
            cycleNode = linkedList.GetNodeAtIndex(6);
            LinkedListFindCycleStart.DetectCycle(linkedList).Should().BeEquivalentTo(cycleNode);
        }

        [TestMethod]
        public void GetIntersectionNodeTest()
        {
            var listA = CommonHelpers.GetLinkedListFromArray(new[] {4, 1, 8, 4, 5});
            var listB = CommonHelpers.GetLinkedListFromArray(new[] {5, 6, 1, 8, 4, 5});
            var intersectionValue = 8;
            CommonHelpers.MakeIntersection(intersectionValue, listA, listB, 2, 3);
            IntersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB).Value.Should().Be(intersectionValue);
            
            listA = CommonHelpers.GetLinkedListFromArray(new[] {1, 51});
            listB = CommonHelpers.GetLinkedListFromArray(new[] {2, 4, 6, 51});
            intersectionValue = 51;
            CommonHelpers.MakeIntersection(intersectionValue, listA, listB, 1, 3);
            IntersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB).Value.Should().Be(intersectionValue);
        }

        [TestMethod]
        public void RemoveNthNodeFromEndOfListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 2, 3, 5
            });
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                2
            });
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2});
            RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 1).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1
            });

            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3});
            RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 3
            });
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3});
            RemoveNthNodeFromEndOfList.RemoveNthFromEnd(list, 3).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                2, 3
            });
        }
    }
}
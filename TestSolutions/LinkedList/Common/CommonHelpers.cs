using System.Diagnostics;
using LeetCode.LinkedList._1_SinglyLinkedList;

namespace TestSolutions.LinkedList.Common
{
    public static class CommonHelpers
    {
        public static MySinglyLinkedList GetCycledLinkedList(int[] values, int cycleIndex)
        {
            var result = GetLinkedListFromArray(values);
            var tail = result.GetTail();
            var cycleNode = result.GetNodeAtIndex(cycleIndex);

            tail.Next = cycleNode;

            return result;
        }

        public static MySinglyLinkedList GetLinkedListFromArray(int[] values)
        {
            var result = new MySinglyLinkedList();
            foreach (var value in values)
            {
                result.AddAtTail(value);
            }

            return result;
        }

        public static void MakeIntersection(int value, MySinglyLinkedList listA, MySinglyLinkedList listB, int skipA, int skipB)
        {
            var nodeA = listA.GetNodeAtIndex(skipA);
            var nodeB = listB.GetNodeAtIndex(skipB);
            
            Debug.Assert(nodeA.Value == nodeB.Value && nodeA.Value == value);

            if (listA.Next != null)
                listA.GetNodeAtIndex(skipA - 1).Next = nodeB;
            
            if (listB.Next != null)
                listB.GetNodeAtIndex(skipB - 1).Next = nodeB;
        }
    }
}
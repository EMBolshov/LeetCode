using System.Collections.Generic;

namespace LeetCode.LinkedList._4_DoublyLinkedList
{
    public static class DoublyLinkedListExtensions
    {
        public static IDoublyLinkedList GetNodeAtIndex(this IDoublyLinkedList current, int index)
        {
            if (index < 0) return null;
            
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            
            return current;
        }

        public static int GetLength(this IDoublyLinkedList head)
        {
            var length = 0;
            
            while (head != null)
            {
                head = head.Next;
                length++;
            }

            return length;
        }

        public static IDoublyLinkedList GetTail(this IDoublyLinkedList head)
        {
            var tail = head;
            while (head != null)
            {
                tail = head;
                head = head.Next;
            }

            return tail;
        }

        public static IEnumerable<int> ValuesToFlatList(this IDoublyLinkedList head)
        {
            var result = new List<int>();

            while (head != null)
            {
                result.Add(head.Value);
                head = head.Next;
            }

            return result;
        }
    }
}
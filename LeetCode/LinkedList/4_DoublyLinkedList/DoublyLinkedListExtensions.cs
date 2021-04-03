using System.Collections.Generic;

namespace LeetCode.LinkedList._4_DoublyLinkedList
{
    public static class DoublyLinkedListExtensions
    {
        public static MyDoublyLinkedList GetNodeAtIndex(this MyDoublyLinkedList current, int index)
        {
            if (index < 0) return null;
            
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            
            return current;
        }

        public static int GetLength(this MyDoublyLinkedList head)
        {
            var length = 0;
            
            while (head != null)
            {
                head = head.Next;
                length++;
            }

            return length;
        }

        public static MyDoublyLinkedList GetTail(this MyDoublyLinkedList head)
        {
            var tail = head;
            while (head != null)
            {
                tail = head;
                head = head.Next;
            }

            return tail;
        }

        public static IEnumerable<int> ValuesToFlatList(this MyDoublyLinkedList head)
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
using System.Collections.Generic;

namespace LeetCode.LinkedList._1_SinglyLinkedList
{
    public static class SinglyLinkedListExtensions
    {
        public static MySinglyLinkedList GetNodeAtIndex(this MySinglyLinkedList current, int index)
        {
            if (index < 0) return null;
            
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            
            return current;
        }

        public static int GetLength(this MySinglyLinkedList head)
        {
            var length = 0;
            
            while (head != null)
            {
                head = head.Next;
                length++;
            }

            return length;
        }

        public static MySinglyLinkedList GetTail(this MySinglyLinkedList head)
        {
            var tail = head;
            while (head != null)
            {
                tail = head;
                head = head.Next;
            }

            return tail;
        }

        public static bool HasCycle(this MySinglyLinkedList head)
        {
            if (head?.Next == null)
                return false;

            if (head.Next == head)
                return true;

            var firstPointer = head;
            var secondPointer = head.Next?.Next;
            if (secondPointer == null)
                return false;

            while (true)
            {
                if (firstPointer == secondPointer)
                    return true;

                firstPointer = firstPointer.Next;
                if (firstPointer == null)
                    return false;

                secondPointer = secondPointer.Next?.Next;
                if (secondPointer == null)
                    return false;
            }
        }

        public static MySinglyLinkedList GetCycleIntersect(this MySinglyLinkedList head)
        {
            var firstPointer = head;
            var secondPointer = head;

            while (firstPointer?.Next != null)
            {
                firstPointer = firstPointer.Next;
                secondPointer = secondPointer?.Next?.Next;

                if (firstPointer == secondPointer)
                    return firstPointer;
            }

            return null;
        }

        public static IEnumerable<int> ValuesToFlatList(this MySinglyLinkedList head)
        {
            var result = new List<int>();

            while (head != null)
            {
                result.Add(head.Value);
                head = head.Next;
            }

            return result;
        }

        public static MySinglyLinkedList ReverseIteratively(this MySinglyLinkedList list)
        {
            MySinglyLinkedList prev = null;

            while (list != null)
            {
                var head = list;
                list = list.Next;
                head.Next = prev;
                prev = head;
            }

            return prev;

        }
        
        public static MySinglyLinkedList ReverseRecursively(this MySinglyLinkedList list)
        {
            return GetNext(list, null);

            MySinglyLinkedList GetNext(MySinglyLinkedList list, MySinglyLinkedList prev)
            {
                if (list != null)
                {
                    var head = list;
                    list = list.Next;
                    head.Next = prev;
                    prev = head;
                    
                    return GetNext(list, prev);
                }

                return prev;
            }
        }

        public static bool IsPalindrome(this MySinglyLinkedList list)
        {
            if (list == null)
                return false;

            if (list.Next == null)
                return true;
            
            var original = list;
            var fast = list;
            var slow = list;
            
            MySinglyLinkedList half = null;
            
            while (fast != null)
            {
                fast = fast.Next?.Next;
                slow = slow.Next;

                if (fast?.Next == null)
                    half = slow;
            }
            
            var halfReversed = half.ReverseIteratively();

            while (halfReversed != null)
            {
                if (original.Value != halfReversed.Value)
                    return false;
                
                halfReversed = halfReversed.Next;
                original = original.Next;
            }

            return true;
        }
    }
}
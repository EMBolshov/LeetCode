using System.Collections.Generic;

namespace LeetCode.LinkedList._1_SinglyLinkedList
{
    public static class SinglyLinkedListExtensions
    {
        public static ISinglyLinkedList GetNodeAtIndex(this ISinglyLinkedList current, int index)
        {
            if (index < 0) return null;
            
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            
            return current;
        }

        public static int GetLength(this ISinglyLinkedList head)
        {
            var length = 0;
            
            while (head != null)
            {
                head = head.Next;
                length++;
            }

            return length;
        }

        public static ISinglyLinkedList GetTail(this ISinglyLinkedList head)
        {
            var tail = head;
            while (head != null)
            {
                tail = head;
                head = head.Next;
            }

            return tail;
        }

        public static bool HasCycle(this ISinglyLinkedList head)
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

        public static ISinglyLinkedList GetCycleIntersect(this ISinglyLinkedList head)
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

        public static IEnumerable<int> ValuesToFlatList(this ISinglyLinkedList head)
        {
            var result = new List<int>();

            while (head != null)
            {
                result.Add(head.Value);
                head = head.Next;
            }

            return result;
        }

        public static ISinglyLinkedList ReverseIteratively(this ISinglyLinkedList list)
        {
            ISinglyLinkedList prev = null;

            while (list != null)
            {
                var head = list;
                list = list.Next;
                head.Next = prev;
                prev = head;
            }

            return prev;

        }
        
        public static ISinglyLinkedList ReverseRecursively(this ISinglyLinkedList list)
        {
            return GetNext(list, null);

            ISinglyLinkedList GetNext(ISinglyLinkedList list, ISinglyLinkedList prev)
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

        public static bool IsPalindrome(this ISinglyLinkedList list)
        {
            if (list == null)
                return false;

            if (list.Next == null)
                return true;
            
            var original = list;
            var fast = list;
            var slow = list;
            
            ISinglyLinkedList half = null;
            
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
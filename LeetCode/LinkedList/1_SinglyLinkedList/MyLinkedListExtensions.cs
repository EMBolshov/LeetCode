using System.Collections.Generic;

namespace LeetCode.LinkedList._1_SinglyLinkedList
{
    public static class MyLinkedListExtensions
    {
        // for (int i = 0; i <= n; i++) {current = current.Next; return current;}
        public static MyLinkedList GetNodeAtIndex(this MyLinkedList current, int index)
        {
            if (index <= 0)
                return current;

            if (current.Next != null)
                return GetNodeAtIndex(current.Next, index - 1);

            return null;
        }

        // while (current.Next != null) { current = current.Next; length++; } return length;
        public static int GetLength(this MyLinkedList current)
        {
            return GetNext(current, 1);

            int GetNext(MyLinkedList current, int depth)
            {
                var length = depth;
                if (current.Next != null)
                {
                    length = GetNext(current.Next, depth + 1);
                }

                return length;
            }
        }

        public static MyLinkedList GetTail(this MyLinkedList head)
        {
            var current = head.Next;
            while (current?.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public static bool HasCycle(this MyLinkedList head)
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

        public static MyLinkedList GetCycleIntersect(this MyLinkedList head)
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

        public static int GetCurrent(this MyLinkedList node)
        {
            return node.Get(0);
        }

        public static IEnumerable<int> ValuesToFlatList(this MyLinkedList head)
        {
            var result = new List<int>();

            while (head != null)
            {
                result.Add(head.GetCurrent());
                head = head.Next;
            }

            return result;
        }

        public static MyLinkedList ReverseIteratively(this MyLinkedList list)
        {
            MyLinkedList prev = null;

            while (list != null)
            {
                var head = list;
                list = list.Next;
                head.Next = prev;
                prev = head;
            }

            return prev;

        }
        
        public static MyLinkedList ReverseRecursively(this MyLinkedList list)
        {
            return GetNext(list, null);

            MyLinkedList GetNext(MyLinkedList list, MyLinkedList prev)
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
    }
}
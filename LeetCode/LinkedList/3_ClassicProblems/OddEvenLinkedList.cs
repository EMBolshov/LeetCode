using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._3_ClassicProblems
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1208/
    /// </summary>
    public static class OddEvenLinkedList
    {
        public static MySinglyLinkedList OddEvenList(MySinglyLinkedList head)
        {
            if (head == null)
                return null;
            
            var result = head;
            var evenFirst = head.Next;

            while (head != null)
            {
                var even = head.Next;
                
                head.Next = head.Next?.Next;

                if (even != null)
                {
                    even.Next = even.Next?.Next;
                }
                else
                {
                    head.Next = evenFirst;
                    head = null;
                    continue;
                }

                head.Next ??= evenFirst;
                if (head.Next == evenFirst)
                {
                    head = null;
                    continue;
                }
                
                head = (MySinglyLinkedList) head.Next;
            }

            return result;
        }
    }
}
using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._3_ClassicProblems
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
    /// </summary>
    public static class RemoveLinkedListElements
    {
        public static MySinglyLinkedList RemoveElements(MySinglyLinkedList head, int val)
        {
            if (head == null)
                return null;
                
            MySinglyLinkedList prev = null;
            var result = head;

            if (head.Next == null && head.Value == val)
                return null;
            
            while (head != null)
            {
                if (head.Value == val)
                {
                    if (prev == null)
                    {
                        result = result.Next;
                        head = head.Next;
                        continue;
                    }

                    prev.Next = head.Next;
                }
                else
                {
                    prev = head;
                }

                head = head.Next;
            }
            
            return result;
        }
    }
}
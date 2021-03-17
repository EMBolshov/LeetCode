using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._3_ClassicProblems
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
    /// </summary>
    public static class RemoveLinkedListElements
    {
        public static MyLinkedList RemoveElements(MyLinkedList head, int val)
        {
            if (head == null)
                return null;
                
            MyLinkedList prev = null;
            var result = head;

            if (head.Next == null && head.GetCurrent() == val)
                return null;
            
            while (head != null)
            {
                if (head.GetCurrent() == val)
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
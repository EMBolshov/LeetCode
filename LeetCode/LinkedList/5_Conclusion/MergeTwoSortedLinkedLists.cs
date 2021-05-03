using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._5_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1227/
    /// </summary>
    public static class MergeTwoSortedLinkedLists
    {
        public static MySinglyLinkedList MergeTwoLists(MySinglyLinkedList l1, MySinglyLinkedList l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            MySinglyLinkedList head;

            if (l1.Value > l2.Value)
            {
                head = l2;
                l2 = l2.Next;
            }
            else
            {
                head = l1;
                l1 = l1.Next;
            }
            
            var result = head;

            while (head != null)
            {
                if (l1?.Value > l2?.Value)
                {
                    head.Next = l2;
                    l2 = l2?.Next;
                }
                else if (l1 != null && l2 != null)
                {
                    head.Next = l1;
                    l1 = l1.Next; 
                }
                else if (l1 == null)
                {
                    head.Next = l2;
                    break;
                }
                else if (l2 == null)
                {
                    head.Next = l1;
                    break;
                }

                head = head.Next;
            }
            
            return result;
        }
    }
}
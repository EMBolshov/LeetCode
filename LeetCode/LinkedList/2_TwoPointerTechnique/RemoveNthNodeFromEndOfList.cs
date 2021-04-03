using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._2_TwoPointerTechnique
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
    /// </summary>
    public static class RemoveNthNodeFromEndOfList
    {
        public static MySinglyLinkedList RemoveNthFromEnd(MySinglyLinkedList head, int n)
        {
            if (head == null || n < 0 || head.Next == null && n == 1)
                return null;

            if (head.Next == null && n == 0)
                return head;

            //The better way is to make something like var tempHead = new MyLinkedList(0); tempHead.Next = head; 
            //so it is better than null and better than head as init value. After I can just prevBeforeNFromEnd.Next = prevBeforeNFromEnd.Next.Next; return tempHead.Next;
            var pointer = head;
            var prevBeforeNFromEnd = head;

            var i = 0;
            while (pointer != null)
            {
                if (i > n)
                    prevBeforeNFromEnd = prevBeforeNFromEnd.Next;

                pointer = pointer.Next;
                i++;
            }

            switch (i)
            {
                case 2 when n == 1:
                    head.Next = null;
                    break;
                case 2 when n == 2:
                    head = head.Next;
                    break;
                default:
                {
                    if (prevBeforeNFromEnd == head && i == n)
                        head = head.Next;
                    else 
                        prevBeforeNFromEnd.Next = prevBeforeNFromEnd.Next?.Next;
                    
                    break;
                }
            }

            return head;
        }
    }
}
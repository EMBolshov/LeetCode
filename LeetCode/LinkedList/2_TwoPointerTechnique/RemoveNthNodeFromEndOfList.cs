using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._2_TwoPointerTechnique
{
    public static class RemoveNthNodeFromEndOfList
    {
        public static MyLinkedList RemoveNthFromEnd(MyLinkedList head, int n)
        {
            if (head == null || n < 0 || head.Next == null && n == 1)
                return null;

            if (head.Next == null && n == 0)
                return head;

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
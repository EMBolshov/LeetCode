using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._2_TwoPointerTechnique
{
    public static class IntersectionOfTwoLinkedLists
    {
        public static MyLinkedList GetIntersectionNode(MyLinkedList headA, MyLinkedList headB)
        {
            if (headA == null || headB == null)
                return null;
            
            if (headA == headB)
                return headA;

            var pointer = headA.Next != null ? headA : headB;
            var current = headA.Next != null ? headB : headA;

            while (pointer != null)
            {
                do
                {
                    if (pointer == current)
                        return pointer;
                    
                    current = current.Next;
                    
                } while (current != null);
                
                pointer = pointer.Next;
                current = headA.Next != null ? headB : headA;
                
            } 
            
            return null;
        }
    }
}
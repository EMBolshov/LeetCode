using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._2_TwoPointerTechnique
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
    /// </summary>
    public static class LinkedListCycle
    {
        //Better place for this method is MyLinkedListExtensions
        public static bool HasCycle(MyLinkedList head)
        {
            if (head?.Next == null)
                return false;

            if (head.Next == head)
                return true;
            
            var firstPointer = head;
            var secondPointer = head.Next?.Next;
            if (secondPointer == null)
                return false;

            if (firstPointer == secondPointer)
                return true;

            while (true)
            {
                firstPointer = firstPointer.Next;
                if (firstPointer == null)
                    return false;

                secondPointer = secondPointer.Next?.Next;
                if (secondPointer == null)
                    return false;

                if (firstPointer == secondPointer)
                    return true;
            }
        }
    }
}
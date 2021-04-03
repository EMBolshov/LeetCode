using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.Recursion_I._1_PricipleOfRecursion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/250/principle-of-recursion/1681/
    /// </summary>
    public static class SwapNodesInPairs
    {
        public static MySinglyLinkedList SwapPairs(MySinglyLinkedList head)
        {
            return Swap(head);

            MySinglyLinkedList Swap(MySinglyLinkedList first)
            {
                if (first == null)
                    return null;
                
                var second = first.Next;
               
                var temp = second?.Next;
                first.Next = temp;

                if (second != null)
                {
                    second.Next = first;
                    first.Next = Swap(first.Next);
                    return second;
                }

                return first;
            }
        }
    }
}
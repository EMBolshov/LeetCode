using System.Linq;
using System.Numerics;
using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._5_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1228/
    /// </summary>
    public static class AddTwoNumbersFromLinkedLists
    {
        //BigInteger is a dirty hack for LeetCodes test cases with long Linked Lists. But right now I'm too lazy to make calculations by myself 
        public static MySinglyLinkedList AddTwoNumbers(MySinglyLinkedList l1, MySinglyLinkedList l2)
        {
            var result = new MySinglyLinkedList();
            var resCopy = result;
            var firstNumber = string.Empty;
            var secondNumber = string.Empty;

            while (l1 != null)
            {
                firstNumber = l1.Value + firstNumber;
                l1 = l1.Next;
            }

            while (l2 != null)
            {
                secondNumber = l2.Value + secondNumber;
                l2 = l2.Next;
            }

            var resultNumber = (BigInteger.Parse(firstNumber) + BigInteger.Parse(secondNumber)).ToString().Reverse();

            foreach (var n in resultNumber)
            {
                resCopy.Next = new MySinglyLinkedList(int.Parse(n.ToString()));
                resCopy = resCopy.Next;
            }

            return result.Next;
        }
    }
}
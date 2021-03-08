using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void HasCycleTest()
        {
            var first = new MyLinkedList(3);
            var second = new MyLinkedList(2);
            var third = new MyLinkedList(0);
            var fourth = new MyLinkedList(-4);

            first.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = second; // Cycle

            LinkedListCycle.HasCycle(first).Should().BeTrue();

            first = new MyLinkedList(1);
            LinkedListCycle.HasCycle(first).Should().BeFalse();
        }
    }
}
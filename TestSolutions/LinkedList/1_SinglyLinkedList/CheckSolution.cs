using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.LinkedList._1_SinglyLinkedList
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void DesignLinkedList()
        {
            var myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);      // linked list becomes 1->2->3
            myLinkedList.Get(1).Should().Be(2); // return 2
            myLinkedList.DeleteAtIndex(1);      // now the linked list is 1->3
            myLinkedList.Get(1).Should().Be(3); // return 3
            
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(0);
            
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtIndex(3, 0);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.AddAtHead(6);
            myLinkedList.AddAtTail(4);
            myLinkedList.Get(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(5, 0);
            myLinkedList.AddAtHead(6);
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtIndex(3, 0);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.AddAtHead(6);
            myLinkedList.AddAtTail(4);
            myLinkedList.Get(4).Should().Be(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(5, 0);
            myLinkedList.AddAtHead(6);
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);
            myLinkedList.Get(1).Should().Be(2);
            myLinkedList.DeleteAtIndex(0);
            myLinkedList.Get(0).Should().Be(2);
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtIndex(0, 10);
            myLinkedList.AddAtIndex(0, 20);
            myLinkedList.AddAtIndex(1, 30);
            myLinkedList.Get(0).Should().Be(20);
            
            myLinkedList = new MyLinkedList();
            myLinkedList.AddAtTail(1);
            myLinkedList.Get(0).Should().Be(1);
        }
    }
}
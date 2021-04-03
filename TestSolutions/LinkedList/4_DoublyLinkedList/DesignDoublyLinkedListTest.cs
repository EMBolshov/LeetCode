using FluentAssertions;
using LeetCode.LinkedList._4_DoublyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.LinkedList._4_DoublyLinkedList
{
    [TestClass]
    public class DesignDoublyLinkedListTest
    {
        [TestMethod]
        public void AddAtIndexTest()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtIndex(0, 10);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(0, 20);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(1, 30);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(0).Should().Be(20);
        }

        [TestMethod]
        public void AddAtTailTest()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtTail(1);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(0).Should().Be(1);
        }

        [TestMethod]
        public void DeleteAtIndex0Test()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtHead(1);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtTail(3);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(1, 2);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(1).Should().Be(2);
            myLinkedList.DeleteAtIndex(0);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(0).Should().Be(2);
        }

        [TestMethod]
        public void AddToDifferentPlacesTestCase2()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtHead(7);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(2);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(1);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(3, 0);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.DeleteAtIndex(2);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(6);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtTail(4);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(4).Should().Be(4);

            myLinkedList.AddAtHead(4);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(5, 0);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(6);
            ValidateDoublyLinkedList(myLinkedList);
        }

        [TestMethod]
        public void AddAtDifferentPlacesTest()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(1);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(3, 0);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.DeleteAtIndex(2);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(6);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtTail(4);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(4).Should().Be(4);
            myLinkedList.AddAtHead(4);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(5, 0);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtHead(6);
            ValidateDoublyLinkedList(myLinkedList);
        }

        [TestMethod]
        public static void AddAtHeadDeleteAt0Test()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(0);

            myLinkedList.Value.Should().Be(-1);
            myLinkedList.Next.Should().BeNull();
            myLinkedList.Prev.Should().BeNull();
        }

        [TestMethod]
        public void AddAtHeadAtTailAtIndexTest()
        {
            var myLinkedList = new MyDoublyLinkedList();
            myLinkedList.AddAtHead(1);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtTail(3);
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.AddAtIndex(1, 2); // linked list becomes 1->2->3
            ValidateDoublyLinkedList(myLinkedList);

            myLinkedList.Get(1).Should().Be(2); // return 2
            myLinkedList.DeleteAtIndex(1); // now the linked list is 1->3
            myLinkedList.Get(1).Should().Be(3); // return 3
        }

        private static void ValidateDoublyLinkedList(MyDoublyLinkedList head)
        {
            head.Prev.Should().BeNull();
            var prev = head; 
            head = head.Next;

            while (head != null)
            {
                head.Prev.Should().BeEquivalentTo(prev);
                prev.Next.Should().BeEquivalentTo(head);

                head = head.Next;
                prev = prev.Next;
            }
        }
    }
}
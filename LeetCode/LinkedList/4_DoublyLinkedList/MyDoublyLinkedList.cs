using System.Diagnostics;

namespace LeetCode.LinkedList._4_DoublyLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/210/doubly-linked-list/1294/
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class MyDoublyLinkedList : IDoublyLinkedList
    {
        private string DebuggerDisplay => GetDebuggerDisplay();

        public IDoublyLinkedList Next { get; set; }
        public IDoublyLinkedList Prev { get; set; }
        public int Value { get; set; }

        public MyDoublyLinkedList()
        {
            Value = -1;
        }

        public MyDoublyLinkedList(int value)
        {
            Value = value;
        }

        public int Get(int index)
        {
            if (index < 0)
                return -1;

            var element = this.GetNodeAtIndex(index);

            if (element == null)
                return -1;

            return element.Value;
        }

        public void AddAtHead(int val)
        {
            if (Value != -1)
            {
                var oldHead = new MyDoublyLinkedList(Value);
                
                var next = Next;
                if (next != null)
                    next.Prev = oldHead;

                oldHead.Next = Next;
                oldHead.Prev = this;
                
                Value = val;
                Next = oldHead;
                Prev = null;
            }
            else
            {
                Value = val;
                Prev = null;
                Next = null;
            }
        }

        public void AddAtTail(int val)
        {
            var newElement = new MyDoublyLinkedList(val);
            var tail = this.GetTail();

            if (tail.Value == -1)
            {
                Value = val;
                return;
            }

            tail.Next = newElement;
            newElement.Prev = tail;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > this.GetLength())
                return;

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            var prev = this.GetNodeAtIndex(index - 1);
            var element = new MyDoublyLinkedList(val) {Prev = prev};
            var next = prev.Next;
            if (next != null)
            {
                next.Prev = element;
            }
            element.Next = prev.Next;
            prev.Next = element;
        }

        public void DeleteAtIndex(int index)
        {
            var prev = this.GetNodeAtIndex(index - 1);
            IDoublyLinkedList next;
            
            if (prev == null)
            {
                Value = Next?.Value ?? -1;
                next = Next?.Next;
                Next = next;
                if (next != null)
                    next.Prev = this;
                
                return;
            }

            next = prev.Next?.Next;
            prev.Next = next;
            if (next != null)
                next.Prev = prev;
        }

        private string GetDebuggerDisplay()
        {
            return string.Join(" | ", this.ValuesToFlatList());
        }
    }
}
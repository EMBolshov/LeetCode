using System.Diagnostics;

namespace LeetCode.LinkedList._1_SinglyLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/
    /// </summary>
    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class MySinglyLinkedList
    {
        private string DebuggerDisplay => GetDebuggerDisplay();
        
        public int Value { get; set; }
        public MySinglyLinkedList Next { get; set; }

        public MySinglyLinkedList()
        {
            Value = -1;
        }

        /** Initialize your data structure here. */
        public MySinglyLinkedList(int value)
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
                var oldHead = new MySinglyLinkedList(Value) {Next = Next};
                Next = oldHead;
                Value = val;
            }
            else
            {
                Value = val;
            }
        }

        public void AddAtTail(int val)
        {
            var newElement = new MySinglyLinkedList(val);
            var tail = this.GetTail();

            if (tail.Value == -1)
            {
                Value = val;
                return;
            }
            
            tail.Next = newElement;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > this.GetLength())
                return;

            var prev = this.GetNodeAtIndex(index - 1);
            var element = new MySinglyLinkedList(val);
            if (prev != null)
            {
                element.Next = prev.Next;
                prev.Next = element;
            }
            else
            {
                var oldHead = new MySinglyLinkedList(Value) {Next = Next};
                Next = oldHead;
                Value = val;
            }
        }

        public void DeleteAtIndex(int index)
        {
            var prev = this.GetNodeAtIndex(index - 1);

            if (prev == null)
            {
                Value = Next?.Value ?? -1;
                Next = Next?.Next;
                return;
            }
            
            var next = prev.Next?.Next;
            prev.Next = next;
        }

        private string GetDebuggerDisplay()
        {
            return string.Join(" | ", this.ValuesToFlatList());
        }
    }
}
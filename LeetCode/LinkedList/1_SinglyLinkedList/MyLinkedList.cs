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
    public class MyLinkedList
    {
        //Probably, nullable int is better. But -1 is already reserved as error code for incorrect index
        private int _value;
        public MyLinkedList Next { get; set; }

        public MyLinkedList()
        {
            _value = -1;
        }

        /** Initialize your data structure here. */
        public MyLinkedList(int value)
        {
            _value = value;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0)
                return -1;
            
            var element = this.GetNodeAtIndex(index);

            if (element == null)
                return -1;
                
            return element._value;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            if (_value != -1)
            {
                var oldHead = new MyLinkedList(_value) {Next = Next};
                Next = oldHead;
                _value = val;
            }
            else
            {
                _value = val;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var newElement = new MyLinkedList(val);
            var tail = GetTail(this);

            if (tail._value == -1)
            {
                _value = val;
                return;
            }
            
            tail.Next = newElement;
            
            MyLinkedList GetTail(MyLinkedList current)
            {
                var tail = current;
                if (current.Next != null)
                    tail = GetTail(current.Next);
                
                return tail;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > this.GetLength())
                return;

            var prev = this.GetNodeAtIndex(index - 1);
            var element = new MyLinkedList(val);
            if (prev != null)
            {
                element.Next = prev.Next;
                prev.Next = element;
            }
            else
            {
                var oldHead = new MyLinkedList(_value) {Next = Next};
                Next = oldHead;
                _value = val;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var prev = this.GetNodeAtIndex(index - 1);

            if (prev == null)
            {
                _value = Next?._value ?? -1;
                Next = Next?.Next;
                return;
            }
            
            var next = prev.Next?.Next;
            prev.Next = next;
        }
    }
}
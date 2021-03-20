namespace LeetCode.LinkedList._4_DoublyLinkedList
{
    public interface IDoublyLinkedList
    {
        public int Value { get; set; }
        public IDoublyLinkedList Next { get; set; }
        public IDoublyLinkedList Prev { get; set; }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index);

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val);

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val);

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val);

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index);
    }
}
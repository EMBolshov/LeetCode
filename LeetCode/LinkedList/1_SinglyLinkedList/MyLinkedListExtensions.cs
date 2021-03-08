namespace LeetCode.LinkedList._1_SinglyLinkedList
{
    public static class MyLinkedListExtensions
    {
        // for (int i = 0; i <= n; i++) {current = current.Next; return current;}
        public static MyLinkedList GetElementAtIndex(this MyLinkedList current, int index)
        {
            if (index == 0)
                return current;

            if (current.Next != null)
                return GetElementAtIndex(current.Next, index - 1);

            return null;
        }
        
        // while (current.Next != null) length++; return length;
        public static int GetLength(this MyLinkedList current)
        {
            return GetNext(current, 1);

            int GetNext(MyLinkedList current, int depth)
            {
                var length = depth;
                if (current.Next != null)
                {
                    length = GetNext(current.Next, depth + 1);
                }

                return length;
            }
        }
    }
}
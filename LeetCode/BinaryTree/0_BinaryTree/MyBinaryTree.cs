using System.Diagnostics;

namespace LeetCode.BinaryTree._0_BinaryTree
{
    [DebuggerDisplay("{Value}")]
    public class MyBinaryTree
    {
        public int Value { get; set; }
        public MyBinaryTree Left { get; set; }
        public MyBinaryTree Right { get; set; }

        public MyBinaryTree()
        {
            
        }
        
        public MyBinaryTree(int value)
        {
            Value = value;
        }
    }
}
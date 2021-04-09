using System.Collections.Generic;
using System.Linq;

namespace LeetCode.QueueStack._1_Queue
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1337/
    /// </summary>
    public class MyCircularQueue
    {
        private readonly int _length;
        private readonly List<int> _values;
        private int _head = -1;
        private int _tail = -1;

        public MyCircularQueue(int length)
        {
            _length = length - 1;
            _values = new List<int>();
            for (int i = 0; i < length; i++)
                _values.Add(-1);
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
                return false;

            if (_tail < _length)
                _tail++;
            else
                _tail = 0;
            
            _values[_tail] = value;

            if (_values.Where(v => v != -1).ToList().Count == 1)
            {
                _head = _tail;
            }
            
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
                return false;
            
            _values[_head] = -1;
            
            if (_head < _length)
                _head++;
            else
                _head = 0;

            return true;
        }

        public int Front()
        {
            return _values.Any(v => v != -1) ? _values.ElementAt(_head) : -1;
        }

        public int Rear()
        {
            return _values.Any(v => v != -1) ? _values.ElementAt(_tail) : -1;
        }

        public bool IsEmpty()
        {
            return _values.All(v => v == -1);
        }

        public bool IsFull()
        {
            return _values.Where(v => v != -1).ToList().Count == _length + 1;
        }

        /// <summary>
        /// Returns values in order they will dequeue from queue
        /// </summary>
        /// <returns>coma separated values</returns>
        public override string ToString()
        {
            var orderedCopy = new List<int>();
            var i = _head;
            
            while (orderedCopy.Count != _values.Where(v => v != -1).ToList().Count)
            {
                orderedCopy.Add(_values.ElementAt(i));
                
                if (i < _length)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            } 
            
            return string.Join(", ", orderedCopy);
        }
    }
}
using FluentAssertions;
using LeetCode.QueueStack._1_Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.QueueStack._1_Queue
{
    [TestClass]
    public class MyCircularQueueTest
    {
        [TestMethod]
        public void MyCircularQueueTestCase1()
        {
            var queue = new MyCircularQueue(3);
            queue.IsEmpty().Should().BeTrue();
            queue.EnQueue(1).Should().BeTrue();
            queue.ToString().Should().Be("1");
            queue.Rear().Should().Be(1);
            queue.Front().Should().Be(1);
            queue.EnQueue(2).Should().BeTrue();
            queue.ToString().Should().Be("1, 2");
            queue.Front().Should().Be(1);
            queue.EnQueue(3).Should().BeTrue();
            queue.ToString().Should().Be("1, 2, 3");
            queue.EnQueue(4).Should().BeFalse();
            queue.Front().Should().Be(1);
            queue.Rear().Should().Be(3);
            queue.IsFull().Should().BeTrue();
            queue.DeQueue().Should().BeTrue();
            queue.ToString().Should().Be("2, 3");
            queue.Front().Should().Be(2);
            queue.EnQueue(4).Should().BeTrue();
            queue.ToString().Should().Be("2, 3, 4");
            queue.Rear().Should().Be(4);
            queue.Front().Should().Be(2);
            queue.DeQueue().Should().BeTrue();
            queue.DeQueue().Should().BeTrue();
            queue.DeQueue().Should().BeTrue();
            queue.DeQueue().Should().BeFalse();
            queue.IsEmpty().Should().BeTrue();
            queue.IsFull().Should().BeFalse();
            queue.EnQueue(1).Should().BeTrue();
            queue.IsEmpty().Should().BeFalse();
        }
    }
}
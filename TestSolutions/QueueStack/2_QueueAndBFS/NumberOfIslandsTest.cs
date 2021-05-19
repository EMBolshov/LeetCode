using FluentAssertions;
using LeetCode.QueueStack._2_QueueAndBFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.QueueStack._2_QueueAndBFS
{
    [TestClass]
    public class NumberOfIslandsTest
    {
        [Ignore]
        [TestMethod]
        public void NumIslandsTestCase1()
        {
            var input = new [] {
                new [] {'1','1','1','1','0'},
                new [] {'1','1','0','1','0'},
                new [] {'1','1','0','0','0'},
                new [] {'0','0','0','0','0'}
            };

            NumberOfIslands.NumIslands(input).Should().Be(1);
        }
        
        [Ignore]
        [TestMethod]
        public void NumIslandsTestCase2()
        {
            var input = new [] {
                new [] {'1','1','0','0','0'},
                new [] {'1','1','0','0','0'},
                new [] {'0','0','1','0','0'},
                new [] {'0','0','0','1','1'}
            };

            NumberOfIslands.NumIslands(input).Should().Be(3);
        }
    }
}
using FluentAssertions;
using LeetCode.OtherProblems.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Medium
{
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        [TestMethod]
        public void MaxAreaTestCase1()
        {
            var input = new[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            ContainerWithMostWater.MaxArea(input).Should().Be(49);
        }
        
        [TestMethod]
        public void MaxAreaTestCase2()
        {
            var input = new[] {1, 1};
            ContainerWithMostWater.MaxArea(input).Should().Be(1);
        }
        
        [TestMethod]
        public void MaxAreaTestCase3()
        {
            var input = new[] {4, 3, 2, 1, 4};
            ContainerWithMostWater.MaxArea(input).Should().Be(16);
        }
        
        [TestMethod]
        public void MaxAreaTestCase4()
        {
            var input = new[] {1, 2, 1};
            ContainerWithMostWater.MaxArea(input).Should().Be(2);
        }
        
        [TestMethod]
        public void MaxAreaTestCase5()
        {
            var input = new[] {2, 1};
            ContainerWithMostWater.MaxArea(input).Should().Be(1);
        }
        
        [TestMethod]
        public void MaxAreaTestCase6()
        {
            var input = new[] {2, 3, 4, 5, 18, 17, 6};
            ContainerWithMostWater.MaxArea(input).Should().Be(17);
        }
        
        [TestMethod]
        public void MaxAreaTestCase7()
        {
            var input = new[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            ContainerWithMostWater.MaxArea(input).Should().Be(25);
        }
    }
}
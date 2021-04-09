using FluentAssertions;
using LeetCode.Recursion_I._3_Memoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._3_Memoization
{
    [TestClass]
    public class ClimbingStairsTest
    {
        [TestMethod]
        public void ClimbStairsTestCase1()
        {
            ClimbingStairs.ClimbStairs(1).Should().Be(1);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase2()
        {
            ClimbingStairs.ClimbStairs(2).Should().Be(2);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase3()
        {
            ClimbingStairs.ClimbStairs(3).Should().Be(3);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase4()
        {
            ClimbingStairs.ClimbStairs(4).Should().Be(5);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase5()
        {
            ClimbingStairs.ClimbStairs(5).Should().Be(8);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase6()
        {
            ClimbingStairs.ClimbStairs(6).Should().Be(13);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase7()
        {
            ClimbingStairs.ClimbStairs(7).Should().Be(21);
        }
        
        [TestMethod]
        public void ClimbStairsTestCase44()
        {
            ClimbingStairs.ClimbStairs(44).Should().Be(1134903170);
        }
    }
}
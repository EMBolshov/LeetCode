using System.Linq;
using FluentAssertions;
using LeetCode.Recursion_I._2_RecurrenceRelation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._2_RecurrenceRelation
{
    [Ignore]
    [TestClass]
    // ReSharper disable once InconsistentNaming
    public class PascalsTriangleIITest
    {
        [TestMethod]
        public void GetRowTestCase1()
        {
            PascalsTriangleII.GetRow(3).SequenceEqual(new[] {1, 3, 3, 1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void GetRowTestCase2()
        {
            PascalsTriangleII.GetRow(0).SequenceEqual(new[] {1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void GetRowTestCase3()
        {
            PascalsTriangleII.GetRow(1).SequenceEqual(new[] {1, 1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void GetRowTestCase4()
        {
            PascalsTriangleII.GetRow(4).SequenceEqual(new[] {1, 4, 6, 4, 1}).Should().BeTrue();
        }
    }
}
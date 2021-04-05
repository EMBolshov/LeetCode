using FluentAssertions;
using LeetCode.Recursion_I._4_ComplexityAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._4_ComplexityAnalysis
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void MyPowTestCase1()
        {
            Pow.MyPow(2, 2).Should().Be(4);
        }
        
        [TestMethod]
        public void MyPowTestCase2()
        {
            Pow.MyPow(3, 2).Should().Be(9);
        }
        
        [TestMethod]
        public void MyPowTestCase3()
        {
            Pow.MyPow(2, 3).Should().Be(8);
        }
        
        [TestMethod]
        public void MyPowTestCase4()
        {
            Pow.MyPow(2, 0).Should().Be(1);
        }
        
        [TestMethod]
        public void MyPowTestCase5()
        {
            Pow.MyPow(2.5, 1).Should().Be(2.5);
        }
        
        [TestMethod]
        public void MyPowTestCase6()
        {
            Pow.MyPow(2.5, 2).Should().Be(6.25);
        }
        
        [TestMethod]
        public void MyPowTestCase7()
        {
            Pow.MyPow(2.00000, -2).Should().Be(0.25);
        }
        
        [TestMethod]
        public void MyPowTestCase8()
        {
            Pow.MyPow(-2, 2).Should().Be(4);
        }
        
        [TestMethod]
        public void MyPowTestCase9()
        {
            Pow.MyPow(-4, -2).Should().Be(0.0625);
        }
        
        [TestMethod]
        public void MyPowTestCase10()
        {
            Pow.MyPow(-2, 3).Should().Be(-8);
        }
        
        [TestMethod]
        public void MyPowTestCase11()
        {
            Pow.MyPow(-4, -3).Should().Be(-0.015625);
        }
        
        [TestMethod]
        public void MyPowTestCase12()
        {
            Pow.MyPow(0.00001, 2147483647).Should().Be(0);
        }
        
        [TestMethod]
        public void MyPowTestCase13()
        {
            Pow.MyPow(1, 2147483647).Should().Be(1);
        }
        
        [TestMethod]
        public void MyPowTestCase14()
        {
            Pow.MyPow(2.000000, -2147483648).Should().Be(0);
        }
    }
}
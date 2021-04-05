using FluentAssertions;
using LeetCode.Recursion_I._3_Memoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._3_Memoization
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        public void GetFibonacciNumberTestCase1()
        {
            FibonacciNumber.Fib(0).Should().Be(0);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase2()
        {
            FibonacciNumber.Fib(1).Should().Be(1);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase3()
        {
            FibonacciNumber.Fib(2).Should().Be(1);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase4()
        {
            FibonacciNumber.Fib(3).Should().Be(2);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase5()
        {
            FibonacciNumber.Fib(4).Should().Be(3);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase6()
        {
            FibonacciNumber.Fib(5).Should().Be(5);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase7()
        {
            FibonacciNumber.Fib(6).Should().Be(8);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase8()
        {
            FibonacciNumber.Fib(7).Should().Be(13);
        }
        
        [TestMethod]
        public void GetFibonacciNumberTestCase9()
        {
            FibonacciNumber.Fib(8).Should().Be(21);
        }
    }
}
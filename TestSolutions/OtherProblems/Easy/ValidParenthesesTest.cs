using FluentAssertions;
using LeetCode.OtherProblems.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Easy
{
    [TestClass]
    public class ValidParenthesesTest
    {
        [TestMethod]
        public void IsValidTestCase1()
        {
            var input = "()";
            ValidParentheses.IsValid(input).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsValidTestCase2()
        {
            var input = "()[]{}";
            ValidParentheses.IsValid(input).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsValidTestCase3()
        {
            var input = "(]";
            ValidParentheses.IsValid(input).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsValidTestCase4()
        {
            var input = "([)]";
            ValidParentheses.IsValid(input).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsValidTestCase5()
        {
            var input = "{[]}";
            ValidParentheses.IsValid(input).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsValidTestCase6()
        {
            var input = "){[]}";
            ValidParentheses.IsValid(input).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsValidTestCase7()
        {
            var input = ")";
            ValidParentheses.IsValid(input).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsValidTestCase8()
        {
            var input = "(";
            ValidParentheses.IsValid(input).Should().BeFalse();
        }
    }
}
using FluentAssertions;
using LeetCode.OtherProblems.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Easy
{
    [TestClass]
    public class PalindromeNumberTest
    {
        [TestMethod]
        public void IsPalindromeTestCase1()
        {
            PalindromeNumber.IsPalindrome(121).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPalindromeTestCase2()
        {
            PalindromeNumber.IsPalindrome(-121).Should().BeFalse();
        }
        
        [TestMethod]
        public void IsPalindromeTestCase3()
        {
            PalindromeNumber.IsPalindrome(1221).Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPalindromeTestCase5()
        {
            PalindromeNumber.IsPalindrome(10).Should().BeFalse();
        }
    }
}
using FluentAssertions;
using LeetCode.OtherProblems.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Medium
{
    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        [TestMethod]
        public void TestCase1()
        {
            var input = "abcabcbb";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(3);
        }
        
        [TestMethod]
        public void TestCase2()
        {
            var input = "bbbbbbb";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(1);
        }
        
        [TestMethod]
        public void TestCase3()
        {
            var input = "pwwkew";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(3);
        }
        
        [TestMethod]
        public void TestCase4()
        {
            var input = "";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(0);
        }
        
        [TestMethod]
        public void TestCase5()
        {
            var input = " ";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(1);
        }
        
        [TestMethod]
        public void TestCase6()
        {
            var input = "c";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(1);
        }
        
        [TestMethod]
        public void TestCase7()
        {
            var input = "au";
            LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input).Should().Be(2);
        }
    }
}
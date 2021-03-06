﻿using System.Linq;
using FluentAssertions;
using LeetCode.Recursion_I._1_PricipleOfRecursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._1_PrincipleOfRecursion
{
    [TestClass]
    public class ReverseStringTest
    {
        [TestMethod]
        public void ReverseStringTestCase1()
        {
            var input = new[] {'h', 'e', 'l', 'l', 'o'};
            ReverseString.StringReverse(input);
            input.SequenceEqual(new[] {'o', 'l', 'l', 'e', 'h'}).Should().BeTrue();
        }
        
        [TestMethod]
        public void ReverseStringTestCase2()
        {
            var input = new[] {'H', 'a', 'n', 'n', 'a', 'h'};
            ReverseString.StringReverse(input);
            input.SequenceEqual(new[] {'h', 'a', 'n', 'n', 'a', 'H'}).Should().BeTrue();
        }
    }
}
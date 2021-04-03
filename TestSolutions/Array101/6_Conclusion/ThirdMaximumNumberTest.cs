using FluentAssertions;
using LeetCode.Arrays101._6_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._6_Conclusion
{
    [TestClass]
    public class ThirdMaximumNumberTest
    {
        [TestMethod]
        public void ThirdMaximumNumberTestCase1()
        {
            var testData = new[] {3, 2, 1};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase2()
        {
            var testData = new[] {1, 2};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase3()
        {
            var testData = new[] {2, 2, 3, 1};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase4()
        {
            var testData = new[] {1, 1, 2};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase5()
        {
            var testData = new[] {2, 2, 2, 1};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase6()
        {
            var testData = new[] {1, 2, 2, 5, 3, 5};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase7()
        {
            var testData = new[] {5, 2, 4, 1, 3, 6, 0};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(4);
        }
        
        [TestMethod]
        public void ThirdMaximumNumberTestCase8()
        {
            var testData = new[] {3, 2, 3, 1, 2, 4, 5, 5, 6};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(4);
        }
    }
}
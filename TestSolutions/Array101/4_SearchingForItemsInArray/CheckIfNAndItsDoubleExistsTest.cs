using FluentAssertions;
using LeetCode.Arrays101._4_SearchingForItemsInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._4_SearchingForItemsInArray
{
    [TestClass]
    public class CheckIfNAndItsDoubleExistsTest
    {
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTestCase1()
        {
            var input = new[] {10, 2, 5, 3};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();
        }
        
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTestCase2()
        {
            var input = new[] {7, 1, 14, 11};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();
        }
        
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTestCase3()
        {
            var input = new[] {-2, 0, 10, -19, 4, 6, -8};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeFalse();
        }
        
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTestCase4()
        {
            var input = new[] {3, 1, 7, 11};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeFalse();
        }
        
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTestCase5()
        {
            var input = new[] {0, 0};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();
        }
    }
}
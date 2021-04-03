using FluentAssertions;
using LeetCode.Arrays101._4_SearchingForItemsInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._4_SearchingForItemsInArray
{
    [TestClass]
    public class ValidMountainArrayTest
    {
        [TestMethod]
        public void ValidMountainArrayTestCase1()
        {
            var input = new[] {2, 1};
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }

        [TestMethod]
        public void ValidMountainArrayTestCase2()
        {
            var input = new[] {3, 5, 5};
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();

        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase3()
        {
            var input = new[] {0, 3, 2, 1};
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeTrue();
        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase4()
        {
            var input = new[] {0, 2, 3, 4, 5, 2, 1, 0};
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeTrue();
        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase5()
        {
            var input = new[] {0, 2, 3, 3, 5, 2, 1, 0}; 
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase6()
        {
            var input = new[] {0, 2, 3, 3, 5, 2, 1, 0}; 
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase7()
        {
            var input = new[] {0, 1, 2, 3, 4, 5, 6, 7}; 
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }
        
        [TestMethod]
        public void ValidMountainArrayTestCase8()
        {
            var input = new[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}; 
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }
    }
}
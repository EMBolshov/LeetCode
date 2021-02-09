using FluentAssertions;
using LeetCode.Arrays101._4_SearchingForItemsInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._4_SearchingForItemsInArray
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void CheckIfNAndItsDoubleExistsTest()
        {
            var input = new[] {10, 2, 5, 3};
            var output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();

            input = new[] {7, 1, 14, 11};
            output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();
            
            input = new[] {-2, 0, 10, -19, 4, 6, -8};
            output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeFalse();
            
            input = new[] {3, 1, 7, 11}; 
            output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeFalse();

            input = new[] {0, 0};
            output = CheckIfNAndItsDoubleExists.CheckIfExist(input);
            output.Should().BeTrue();
        }

        [TestMethod]
        public void ValidMountainArrayTest()
        {
            var input = new[] {2, 1};
            var output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
            
            input = new[] {3, 5, 5};
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
            
            input = new[] {0, 3, 2, 1};
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeTrue();
            
            input = new[] {0, 2, 3, 4, 5, 2, 1, 0};
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeTrue();
            
            input = new[] {0, 2, 3, 3, 5, 2, 1, 0}; 
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
            
            input = new[] {0, 2, 3, 3, 5, 2, 1, 0}; 
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
            
            input = new[] {0, 1, 2, 3, 4, 5, 6, 7}; 
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
            
            input = new[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}; 
            output = ValidMountainArray.IsValidMountainArray(input);
            output.Should().BeFalse();
        }
    }
}
using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._6_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._6_Conclusion
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTest()
        {
            var input = new[] {4, 3, 2, 7, 8, 2, 3, 1};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {5, 6}).Should().BeTrue();

            input = new[] {1, 1};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {2}).Should().BeTrue();
            
            input = new[] {10, 2, 5, 10, 9, 1, 1, 4, 3, 7};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {6, 8}).Should().BeTrue();
            
            input = new int[0];
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new int[0]).Should().BeTrue();
            
            input = new[] {2, 2};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {1}).Should().BeTrue();
            
            input = new[] {1, 1, 2, 2};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {3, 4}).Should().BeTrue();
            
            input = new[] {5, 4, 6, 7, 9, 3, 10, 9, 5, 6};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {1, 2, 8}).Should().BeTrue();
            
            input = new[] {27,40,6,21,14,36,10,19,44,10,41,26,39,20,25,19,14,7,29,27,40,38,11,44,4,6,48,39,9,13,7,45,41,23,31,8,24,1,3,5,28,11,49,29,18,4,38,32,24,15};
            output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {2,12,16,17,22,30,33,34,35,37,42,43,46,47,50}).Should().BeTrue();
        }

        [TestMethod]
        public void HeightCheckerTest()
        {
            
        }

        [TestMethod]
        public void ThirdMaximumNumberTest()
        {
            var testData = new[] {3, 2, 1};
            var result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(1);
            
            testData = new[] {1, 2};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
            
            testData = new[] {2, 2, 3, 1};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(1);
            
            testData = new[] {1, 1, 2};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
            
            testData = new[] {2, 2, 2, 1};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
            
            testData = new[] {1, 2, 2, 5, 3, 5};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(2);
            
            testData = new[] {5, 2, 4, 1, 3, 6, 0};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(4);
            
            testData = new[] {3, 2, 3, 1, 2, 4, 5, 5, 6};
            result = ThirdMaximumNumber.ThirdMax(testData);
            result.Should().Be(4);
        }
    }
}
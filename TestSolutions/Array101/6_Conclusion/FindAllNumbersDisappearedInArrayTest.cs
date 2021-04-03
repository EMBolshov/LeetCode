using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._6_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._6_Conclusion
{
    [TestClass]
    public class FindAllNumbersDisappearedInArrayTest
    {
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase1()
        {
            var input = new[] {4, 3, 2, 7, 8, 2, 3, 1};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {5, 6}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase2()
        {
            var input = new[] {1, 1};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {2}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase3()
        {
            var input = new[] {10, 2, 5, 10, 9, 1, 1, 4, 3, 7};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {6, 8}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase4()
        { 
            var input = new int[0];
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new int[0]).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase5()
        {
            var input = new[] {2, 2};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase6()
        {
            var input = new[] {1, 1, 2, 2};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {3, 4}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase7()
        {
            var input = new[] {5, 4, 6, 7, 9, 3, 10, 9, 5, 6};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {1, 2, 8}).Should().BeTrue();
        }
        
        [TestMethod]
        public void FindAllNumbersDisappearedInArrayTestCase8()
        {
            var input = new[] {27,40,6,21,14,36,10,19,44,10,41,26,39,20,25,19,14,7,29,27,40,38,11,44,4,6,48,39,9,13,7,45,41,23,31,8,24,1,3,5,28,11,49,29,18,4,38,32,24,15};
            var output = FindAllNumbersDisappearedInArray.FindDisappearedNumbers(input);
            output.SequenceEqual(new[] {2,12,16,17,22,30,33,34,35,37,42,43,46,47,50}).Should().BeTrue();
        }
    }
}
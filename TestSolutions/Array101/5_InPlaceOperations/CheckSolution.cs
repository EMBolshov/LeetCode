using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._5_InPlaceOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._5_InPlaceOperations
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void ReplaceElementsTest()
        {
            var input = new[] {17, 18, 5, 4, 6, 1};
            var output = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(input);
            output.SequenceEqual(new[] {18, 6, 6, 6, 1, -1}).Should().BeTrue();

            input = new[] {400};
            output = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(input);
            output.SequenceEqual(new[] {-1}).Should().BeTrue();
        }

        [TestMethod]
        public void MoveZeroesInPlaceTest()
        {
            var testData = new[] {0, 1, 0, 3, 12};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {1, 3, 12, 0, 0});

            testData = new[] {0};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {0});

            testData = new[] {0, 0, 1};
            MoveZeroesInPlace.MoveZeroes(testData);
            testData.Should().StartWith(new[] {1, 0, 0});
        }

        [TestMethod]
        public void SortArrayByParityTest()
        {
            var input = new[] {3, 1, 2, 4};
            var output = SortArrayByParityInPlace.SortArrayByParity(input);
            output.SequenceEqual(new[] {2, 4, 3, 1}).Should().BeTrue();

            input = new[]
            {
                3363, 4833, 290, 3381, 4227, 1711, 1253, 2984, 2212, 874, 2358, 2049, 2846, 2543, 1557, 1786, 4189,
                1254, 2803, 62, 3708, 1679, 228, 1404, 1200, 4766, 1761, 1439, 1796, 4735, 3169, 3106, 3578, 1940, 2072,
                3254, 7, 961, 1672, 1197, 3187, 1893, 4377, 2841, 2072, 2011, 3509, 2091, 3311, 233
            };
            output = SortArrayByParityInPlace.SortArrayByParity(input);
            output.SequenceEqual(new[]
            {
                290, 2984, 2212, 874, 2358, 2846, 1786, 1254, 62, 3708, 228, 1404, 1200, 4766, 1796, 3106, 3578, 1940,
                2072, 3254, 1672, 2072, 3363, 4833, 3381, 4227, 1711, 1253, 2049, 2543, 1557, 4189, 2803, 1679, 1761,
                1439, 4735, 3169, 7, 961, 1197, 3187, 1893, 4377, 2841, 2011, 3509, 2091, 3311, 233
            }).Should().BeTrue();
        }
    }
}
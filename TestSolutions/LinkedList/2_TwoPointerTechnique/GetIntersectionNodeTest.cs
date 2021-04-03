using FluentAssertions;
using LeetCode.LinkedList._2_TwoPointerTechnique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._2_TwoPointerTechnique
{
    [TestClass]
    public class GetIntersectionNodeTest
    {
        [TestMethod]
        public void GetIntersectionNodeTestCase1()
        {
            var listA = CommonHelpers.GetLinkedListFromArray(new[] {4, 1, 8, 4, 5});
            var listB = CommonHelpers.GetLinkedListFromArray(new[] {5, 6, 1, 8, 4, 5});
            var intersectionValue = 8;
            CommonHelpers.MakeIntersection(intersectionValue, listA, listB, 2, 3);
            IntersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB).Value.Should().Be(intersectionValue);
        }
        
        [TestMethod]
        public void GetIntersectionNodeTestCase2()
        {
            var listA = CommonHelpers.GetLinkedListFromArray(new[] {1, 51});
            var listB = CommonHelpers.GetLinkedListFromArray(new[] {2, 4, 6, 51});
            var intersectionValue = 51;
            CommonHelpers.MakeIntersection(intersectionValue, listA, listB, 1, 3);
            IntersectionOfTwoLinkedLists.GetIntersectionNode(listA, listB).Value.Should().Be(intersectionValue);
        }
    }
}
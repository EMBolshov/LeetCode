﻿using System.Collections.Generic;
using FluentAssertions;
using LeetCode.LinkedList._1_SinglyLinkedList;
using LeetCode.LinkedList._3_ClassicProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolutions.LinkedList.Common;

namespace TestSolutions.LinkedList._3_ClassicProblems
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void ReverseListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            ReverseLinkedList.ReverseList(list).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                5, 4, 3, 2, 1
            });
        }

        [TestMethod]
        public void RemoveLinkedListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 6, 3, 4, 5, 6});
            RemoveLinkedListElements.RemoveElements(list, 6).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 2, 3, 4, 5
            });
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {7, 7, 7, 7});
            RemoveLinkedListElements.RemoveElements(list, 7).ValuesToFlatList().Should().BeEquivalentTo(new List<int>());
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 2, 1});
            RemoveLinkedListElements.RemoveElements(list, 2).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 1
            });

        }
        
        [TestMethod]
        public void OddEvenListTest()
        {
            var list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5});
            OddEvenLinkedList.OddEvenList(list).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 3, 5, 2, 4
            });
            
            list = CommonHelpers.GetLinkedListFromArray(new[] {1, 2, 3, 4, 5, 6, 7, 8});
            OddEvenLinkedList.OddEvenList(list).ValuesToFlatList().Should().BeEquivalentTo(new List<int>
            {
                1, 3, 5, 7, 2, 4, 6, 8
            });
        }
    }
}
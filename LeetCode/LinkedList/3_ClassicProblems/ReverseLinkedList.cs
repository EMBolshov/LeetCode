﻿using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._3_ClassicProblems
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1205/
    /// </summary>
    public static class ReverseLinkedList
    {
        public static MySinglyLinkedList ReverseList(MySinglyLinkedList list)
        {
            //return (MySingleLinkedList) list.ReverseIteratively();
            return (MySinglyLinkedList) list.ReverseRecursively();
        }
    }
}
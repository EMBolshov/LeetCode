﻿using LeetCode.LinkedList._1_SinglyLinkedList;

namespace LeetCode.LinkedList._2_TwoPointerTechnique
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1214/
    /// </summary>
    public static class LinkedListFindCycleStart
    {
        public static MyLinkedList DetectCycle(MyLinkedList head)
        {
            if (head?.Next == null)
                return null;
            
            var intersect = head.GetIntersect();
            if (intersect == null)
                return null;

            var current = head;
            while (current != intersect)
            {
                current = current.Next;
                intersect = intersect.Next;
            }

            return current;
        }
    }
}
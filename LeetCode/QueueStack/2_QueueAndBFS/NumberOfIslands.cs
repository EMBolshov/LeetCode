using System.Collections.Generic;

namespace LeetCode.QueueStack._2_QueueAndBFS
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/
    /// </summary>
    public static class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            var result = 0;

            var flatGrid = new List<int>();
            
            //строить дерево -- корень - ячейка 0,0, от него дети ячейки справа и вниз. дальше обработка поуровнево - 
            //если на уровне только нули -- отсчитывать остров
            //можно не строить дерево, формировать очередь сразу по смещению ячеек внутри строки
            //обработку можно делать по 2^n 

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    
                }
            }
            
            
            return result;
        }
    }
}
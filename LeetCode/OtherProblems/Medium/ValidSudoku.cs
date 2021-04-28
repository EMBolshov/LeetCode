using System.Collections.Generic;
using System.Linq;

namespace LeetCode.OtherProblems.Medium
{
    public static class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            if (board.Length != 9)
                return false;

            var rows = new List<List<int>>();
            
            var columns = new []
            {
                new List<int>(),
                new List<int>(),
                new List<int>(),
                
                new List<int>(),
                new List<int>(),
                new List<int>(),

                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            
            var subBoxes = new []
            {
                new List<int>(),
                new List<int>(),
                new List<int>(),
                
                new List<int>(),
                new List<int>(),
                new List<int>(),

                new List<int>(),
                new List<int>(),
                new List<int>()
            };

            for (int i = 0; i < 9; i++)
            {
                if (board[i].Length != 9)
                    return false;

                var row = new List<int>();
                
                for (int j = 0; j < 9; j++)
                {
                    if (int.TryParse(board[i][j].ToString(), out var n))
                    {
                        if (n < 1 || n > 9)
                            return false;

                        row.Add(n);
                        
                        
                        if (i < 3 && j < 3)
                            subBoxes[0].Add(n);
                        
                        if (i < 3 && j >= 3 && j <= 5)
                            subBoxes[1].Add(n);
                        
                        if (i < 3 && j > 5)
                            subBoxes[2].Add(n);
                        
                        
                        
                        if (i >= 3 && i <= 5 && j < 3)
                            subBoxes[3].Add(n);
                        
                        if (i >= 3 && i <= 5 && j >= 3 && j <= 5)
                            subBoxes[4].Add(n);
                        
                        if (i >= 3 && i <= 5 && j > 5)
                            subBoxes[5].Add(n);
                        
                        
                        
                        if (i > 5 && j < 3)
                            subBoxes[6].Add(n);
                        
                        if (i > 5 && j >= 3 && j <= 5)
                            subBoxes[7].Add(n);
                        
                        if (i > 5 && j > 5)
                            subBoxes[8].Add(n);

                        columns[j].Add(n);
                    }
                }

                rows.Add(row);
            }


            if (rows.Any(r => r.GroupBy(n => n).Any(n => n.Count() > 1)))
            {
                return false;
            }

            if (columns.Any(r => r.GroupBy(n => n).Any(n => n.Count() > 1)))
            {
                return false;
            }

            if (subBoxes.Any(r => r.GroupBy(n => n).Any(n => n.Count() > 1)))
            {
                return false;
            }

            return true;
        }
    }
}
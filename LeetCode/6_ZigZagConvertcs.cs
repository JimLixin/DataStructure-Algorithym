using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public static class ZigZagConvertHelper
    {
        public static string ZigZagConvert(string s, int numRows)
        {
            if (numRows <= 1)
                return s;
            int m = s.Length;
            int blockSize = 2 * (numRows - 1);
            int blockCount = (int)Math.Ceiling((decimal)m / blockSize);
            char[,] matrix = new char[numRows, blockCount * (numRows - 1)];

            int blockIndex = 0;
            for (int i = 0; i < m; i++)
            {
                if (i > 0 && i % blockSize == 0)
                {
                    blockIndex++;
                }
                int currentRow = i % blockSize >= numRows ? ((numRows - 1) - (i % (numRows - 1))) : i % blockSize;
                int currentCol = i % blockSize >= numRows ? (i % (numRows - 1) + blockIndex * (numRows - 1)) : blockIndex * (numRows - 1);
                matrix[currentRow, currentCol] = s[i];
            }

            char[] output = new char[m];
            int counter = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < blockCount * (numRows - 1); j++)
                {
                    if ((int)matrix[i, j] != 0)
                    {
                        output[counter] = matrix[i, j];
                        counter++;
                    }
                    Console.Write((int)matrix[i, j] != 0 ? (new String(new char[] { matrix[i, j] }) + " ") : "  ");
                }
                Console.Write("\r\n");
            }
            return new String(output);
        }
    }
}

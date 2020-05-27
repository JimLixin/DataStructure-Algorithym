using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// 6. Z 字形变换
    /// https://leetcode-cn.com/problems/zigzag-conversion/
    /// </summary>
    public static class ZigZagConvert
    {
        public static string Answer1(string s, int numRows)
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

        public static string Answer2(string s, int numRows)
        {
            if (numRows <= 1)
                return s;
            int m = s.Length;
            int blockSize = 2 * (numRows - 1);
            int blockCount = (int)Math.Ceiling((decimal)m / blockSize);
            StringBuilder output = new StringBuilder();
            int index = 0;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < blockCount; j++)
                {
                    if (i% (numRows - 1) == 0)
                    {
                        index = j * blockSize + i;
                        if (index > m - 1)
                        {
                            break;
                        }
                        output.Append(s[index]);
                    }
                    else
                    {
                        index = j * blockSize + i;
                        if (index > m - 1)
                        {
                            break;
                        }
                        output.Append(s[index]);
                        index = blockSize * (j + 1) - i;
                        if (index > m - 1)
                        {
                            break;
                        }
                        output.Append(s[index]);
                    }
                }
            }
            return output.ToString();
        }
    }
}

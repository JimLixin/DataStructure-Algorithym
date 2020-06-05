using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 168. Excel表列名称
/// https://leetcode-cn.com/problems/excel-sheet-column-title/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00168_Excel表列名称
    {
        public string ConvertToTitle(int n)
        {
            if (n <= 0) return "";
            string s = "";
            while (n-- != 0)
            {
                s = (char)(n % 26 + 'A') + s;
                n = n / 26;
            }
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 824. 山羊拉丁文
/// https://leetcode-cn.com/problems/goat-latin/
/// </summary>
namespace Algorithym.LeetCode
{
    public class 山羊拉丁文
    {
        public string ToGoatLatin(string S)
        {
            HashSet<char> map = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            string[] array = S.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (map.Contains(array[i][0]))
                    sb.Append(array[i]);
                else
                {
                    char tmp = array[i][0];
                    sb.Append(array[i].Remove(0, 1));
                    sb.Append(tmp);
                }
                sb.Append("ma");
                sb.Append(Enumerable.Repeat('a', i + 1).ToArray());
                if (i < array.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}

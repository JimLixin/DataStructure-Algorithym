using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.LCCI
{
    public class T9键盘
    {
        List<string> result;
        int len;
        Dictionary<char, char[]> dic;
        public IList<string> GetValidT9Words(string num, string[] words)
        {
            result = new List<string>();
            if (string.IsNullOrEmpty(num)) return result;
            len = num.Length;
            result.AddRange(words);

            dic = new Dictionary<char, char[]>();
            dic.Add('2', new char[] { 'a', 'b', 'c' });
            dic.Add('3', new char[] { 'd', 'e', 'f' });
            dic.Add('4', new char[] { 'g', 'h', 'i' });
            dic.Add('5', new char[] { 'j', 'k', 'l' });
            dic.Add('6', new char[] { 'm', 'n', 'o' });
            dic.Add('7', new char[] { 'p', 'q', 'r', 's' });
            dic.Add('8', new char[] { 't', 'u', 'v' });
            dic.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            for (int i = 0; i < num.Length; i++)
            {
                char[] charArr = dic[num[i]];
                for (int j = 0; j < words.Length; j++)
                {
                    if (!charArr.Contains(words[j][i]))
                        result.Remove(words[j]);
                }
            }
            return result;
        }
    }
}

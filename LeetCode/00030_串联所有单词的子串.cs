using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 30. 串联所有单词的子串
/// https://leetcode-cn.com/problems/substring-with-concatenation-of-all-words/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00030_串联所有单词的子串
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            if (words == null || words.Length == 0)
                return new int[0];
            int len = words[0].Length, count1 = 0, count2 = 0;
            if (s.Length < len * words.Length) return new int[0];
            IList<int> result = new List<int>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, int> data = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (dic.ContainsKey(w))
                    dic[w]++;
                else
                    dic.Add(w, 1);
                count1++;
            }
            for (int i = 0; i < len; i++)
            {
                int left = i, right = len + i;
                count2 = 0;
                data.Clear();
                while (right <= s.Length)
                {
                    string key = s.Substring(right - len, len);
                    if (dic.ContainsKey(key))
                    {
                        if (data.ContainsKey(key))
                            data[key]++;
                        else
                            data.Add(key, 1);
                        count2++;

                        while (data[key] > dic[key])
                        {
                            string k = s.Substring(left, len);
                            data[k]--;
                            if (data[k] == 0) data.Remove(k);
                            left += len;
                            count2--;
                        }

                        if (count2 == count1)
                        {
                            result.Add(left);
                            string k = s.Substring(left, len);
                            data[k]--;
                            if (data[k] == 0) data.Remove(k);
                            left += len;
                            count2--;
                        }
                    }
                    else
                    {
                        left = right;
                        data.Clear();
                        count2 = 0;
                    }
                    right += len;
                }
            }

            return result;
        }
    }
}

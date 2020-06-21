using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 49. 字母异位词分组
/// https://leetcode-cn.com/problems/group-anagrams/
/// </summary>
namespace Algorithym.LeetCode
{
    
    public class group_anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            foreach (string s in strs)
            {
                char[] sArr = s.ToCharArray();
                Array.Sort(sArr);
                string key = new String(sArr);
                if (!dic.ContainsKey(key))
                    dic.Add(key, new List<string>() { s });
                else
                    dic[key].Add(s);
            }

            foreach (string k in dic.Keys)
            {
                result.Add(dic[k]);
            }
            return result;
        }
    }
}

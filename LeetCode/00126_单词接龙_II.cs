using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 126. 单词接龙 II
/// https://leetcode-cn.com/problems/word-ladder-ii/
/// </summary>
namespace Algorithym.LeetCode
{
    /// <summary>
    /// DFS (超时)
    /// </summary>
    public class _00126_单词接龙_II
    {
        IList<IList<string>> result;
        List<string> data;
        HashSet<string> wdList;
        Dictionary<string, bool> vis;
        string target;
        int minStep;
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            result = new List<IList<string>>();
            wdList = new HashSet<string>(wordList);
            if (!wdList.Contains(endWord)) return result;
            target = endWord;
            minStep = wordList.Count + 1;
            vis = new Dictionary<string, bool>();
            data = new List<string>(new string[] { beginWord });
            dfs(beginWord, 0);
            return result;
        }

        public void dfs(string s, int step)
        {
            if (s == target)
            {
                if (step < minStep)
                {
                    minStep = step;
                    result.Clear();
                    result.Add(new List<string>(data.ToArray()));
                }
                else if (step == minStep)
                    result.Add(new List<string>(data.ToArray()));
                return;
            }
            var list = helper(s);
            //Console.WriteLine($"Get {list.Count} words from {s}.");
            foreach (string item in list)
            {
                if (!vis.ContainsKey(item) || !vis[item])
                {
                    vis[item] = true;
                    data.Add(item);
                    dfs(item, step + 1);
                    data.RemoveAt(data.Count - 1);
                    vis[item] = false;
                }
            }
        }

        public HashSet<string> helper(string s)
        {
            HashSet<string> ret = new HashSet<string>();
            var arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char cur = arr[i];
                for (char j = 'a'; j < 'z'; j++)
                {
                    if (cur == j) continue;
                    arr[i] = j;
                    string key = new String(arr);
                    if (wdList.Contains(key)) ret.Add(key);
                }
                arr[i] = cur;
            }
            return ret;
        }
    }

    /// <summary>
    /// BFS
    /// 执行用时 :2920 ms, 在所有 C# 提交中击败了11.11%的用户
    /// 内存消耗 :48.6 MB, 在所有 C# 提交中击败了100.00%的用户
    /// </summary>
    public class _00126_单词接龙_II_V2
    {
        HashSet<string> wdList;
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            IList<IList<string>> result = new List<IList<string>>();
            wdList = new HashSet<string>(wordList);
            if (!wdList.Contains(endWord)) return result;
            int minStep = wordList.Count + 1;
            Queue<List<string>> q = new Queue<List<string>>();
            HashSet<string> visited = new HashSet<string>(new string[] { beginWord });
            q.Enqueue(new List<string>(new string[] { beginWord }));
            while (q.Count > 0)
            {
                int cnt = q.Count;
                List<string> tmpVisited = new List<string>();
                for (int i = 0; i < cnt; i++)
                {
                    List<string> list = q.Dequeue();
                    int size = list.Count;
                    string curWord = list[size - 1];
                    if (curWord == endWord)
                    {
                        if (size < minStep)
                        {
                            minStep = size;
                            result.Clear();
                            result.Add(list);
                        }
                        else if (size == minStep)
                            result.Add(list);
                        continue;
                    }
                    var newWords = helper(curWord);
                    //Console.WriteLine($"get {newWords.Count} from {curWord}.");
                    foreach (string nw in newWords)
                    {
                        if (!visited.Contains(nw))
                        {
                            List<string> newList = new List<string>(list.ToArray());
                            newList.Add(nw);
                            tmpVisited.Add(nw);
                            q.Enqueue(newList);
                        }
                    }
                }
                if (minStep < wordList.Count + 1) break;
                foreach (string v in tmpVisited) visited.Add(v);
            }

            return result;
        }

        public HashSet<string> helper(string s)
        {
            HashSet<string> ret = new HashSet<string>();
            var arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char cur = arr[i];
                for (char j = 'a'; j < 'z'; j++)
                {
                    if (cur == j) continue;
                    arr[i] = j;
                    string key = new String(arr);
                    if (wdList.Contains(key)) ret.Add(key);
                }
                arr[i] = cur;
            }
            return ret;
        }
    }
}

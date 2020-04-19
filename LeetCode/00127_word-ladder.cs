using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// DFS
    /// Time Limit Exceeded
    /// </summary>
    public class word_ladder
    {
        string[] data = null;
        bool[] vis = null;
        int shortest = int.MaxValue;
        string begin, end;
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList == null || wordList.Count == 0)
                return 0;
            int len = wordList.Count;
            data = new string[len + 1];
            vis = new bool[len];
            begin = beginWord;
            end = endWord;
            dfs(wordList, 0, begin);
            return shortest == int.MaxValue ? 0 : shortest;
        }

        public void dfs(IList<string> wordList, int step, string currentWord)
        {
            if (currentWord == end)
            {
                shortest = Math.Min(shortest, step);
                Console.WriteLine("<==== Result find!=====>");
                Console.WriteLine("shortest: " + shortest + ", path:" + string.Join(",", data));
                Console.WriteLine("<==== Result find!=====>");
                return;
            }
            if (step >= wordList.Count)
            {
                return;
            }

            Dictionary<int, string> next = getNext(wordList, currentWord);
            Console.WriteLine("data:" + string.Join(",", data) + "current word " + currentWord + " with step " + step + ", next:" + string.Join(",", next.Values.ToArray()));
            foreach (int k in next.Keys)
            {
                if (!vis[k])
                {
                    vis[k] = true;
                    data[step] = next[k];
                    dfs(wordList, step + 1, next[k]);
                    data[step] = null;
                    vis[k] = false;
                }
            }
        }

        public Dictionary<int, string> getNext(IList<string> wordList, string cur)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i] == cur)
                    continue;
                int diff = 0;
                for (int j = 0; j < cur.Length; j++)
                {
                    if (diff > 1)
                        break;
                    if (wordList[i][j] != cur[j])
                        diff++;
                }
                if (diff == 1)
                    dic.Add(i, wordList[i]);
            }
            return dic;
        }
    }

    /// <summary>
    /// BFS
    /// Runtime: 496 ms, faster than 47.13% of C# online submissions for Word Ladder.
    /// Memory Usage: 30.6 MB, less than 16.67% of C# online submissions for Word Ladder.
    /// </summary>
    public class word_ladderV2
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList == null || wordList.Count == 0)
                return 0;

            var _wordList = new HashSet<string>(wordList);
            HashSet<string> data = new HashSet<string>();
            int level = 1;
            Queue<string> q = new Queue<string>();
            q.Enqueue(beginWord);
            data.Add(beginWord);
            while (q.Any())
            {
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    string s = q.Dequeue();
                    if (s == endWord)
                        return level;
                    IList<string> next = getNext2(s);
                    foreach (string n in next)
                    {
                        if (_wordList.Contains(n) && !data.Contains(n))
                        {
                            q.Enqueue(n);
                            data.Add(n);
                        }
                    }
                }
                level++;
            }
            return 0;
        }

        public List<string> getNext2(string s)
        {
            var ret = new List<string>();
            char[] arr = s.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                char cur = arr[i];
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (cur == j) continue;
                    arr[i] = j;
                    ret.Add(new string(arr));
                }
                arr[i] = cur;
            }
            return ret;
        }
    }
}

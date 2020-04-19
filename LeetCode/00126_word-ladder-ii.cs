using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public class _00126_word_ladder_ii
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, IList<IList<string>>> data = new Dictionary<string, IList<IList<string>>>();
            HashSet<string> _wordList = new HashSet<string>(wordList);
            Queue<string> q = new Queue<string>();
            int level = 0;
            q.Enqueue(beginWord);
            data.Add(beginWord, new List<IList<string>>());
            data[beginWord].Add(new List<string>(new string[] { beginWord }));

            while (q.Count > 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    string s = q.Dequeue();
                    if (s == endWord)
                        return data[s];
                    var next = getNext(s);
                    foreach (string n in next)
                    {
                        if (_wordList.Contains(n))
                        {
                            if (data.ContainsKey(n))
                            {
                                var path = data[n];
                                
                            }
                            else
                            {
                                IList<IList<string>> tmp = new List<IList<string>>();
                                IList<string>[] path = data[s].ToArray();
                                Array.ForEach(path, p => {
                                    var newList = new List<string>(p);
                                    newList.Add(n);
                                    tmp.Add(newList);
                                });
                                data.Add(n, tmp);
                                
                            }
                            q.Enqueue(n);
                        }
                    }
                }
                level++;
            }
            return result;
        }

        public List<string> getNext(string s)
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

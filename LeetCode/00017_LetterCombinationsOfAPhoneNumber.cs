using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    public static class LetterCombinationsOfAPhoneNumber
    {
        private static IList<string> result = new List<string>();
        private static bool[] vis;
        private static int level;
        private static char[] data;
        public static IList<string> Answer(string digits)
        {
            Dictionary<char, char[]> map = new Dictionary<char, char[]>();
            map.Add('2', new[] { 'a', 'b', 'c' });
            map.Add('3', new[] { 'd', 'e', 'f' });
            map.Add('4', new[] { 'g', 'h', 'i' });
            map.Add('5', new[] { 'j', 'k', 'l' });
            map.Add('6', new[] { 'm', 'n', 'o' });
            map.Add('7', new[] { 'p', 'q', 'r', 's' });
            map.Add('8', new[] { 't', 'u', 'v' });
            map.Add('9', new[] { 'w', 'x', 'y', 'z' });

            List<char[]> input = new List<char[]>();
            for (int i = 0; i < digits.Length; i++)
            {
                if (map.ContainsKey(digits[i]))
                    input.Add(map[digits[i]]);
            }

            level = input.Count;
            data = new char[level];
            vis = new bool[level + 1];

            if (level > 0)
            {
                _answer(0, input.ToArray());
            }
            return result;
        }

        private static void _answer(int step, char[][] charArrays)
        {
            if (step >= level)
            {
                result.Add(new string(data));
                return;
            }

            for (int i = 0; i < charArrays[step].Length; i++)
            {
                if (!vis[step])
                {
                    vis[step] = true;
                    data[step] = charArrays[step][i];
                    _answer(step + 1, charArrays);
                    vis[step] = false;
                }
            }
            
        }
    }
}

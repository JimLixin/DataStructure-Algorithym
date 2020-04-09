using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/
    /// </summary>
    public class add_binary
    {
        public string AddBinary(string a, string b)
        {
            int alen = a.Length, blen = b.Length, len = Math.Max(alen, blen), tmp = 0, flag = 0;
            if (alen > blen)
                b = b.PadLeft(alen, '0');
            else
                a = a.PadLeft(blen, '0');

            char[] data = new char[len];
            while (len > 0)
            {
                tmp = (a[len - 1] - 48) + (b[len - 1] - 48) + flag;
                data[len - 1] = (char)(tmp % 2 + 48);
                flag = tmp / 2;
                len--;
            }

            return new String(flag > 0 ? (new char[] { '1' }).Concat(data).ToArray() : data);
        }
    }
}

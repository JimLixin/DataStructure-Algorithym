using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 67. 二进制求和
/// https://leetcode-cn.com/problems/add-binary/
/// </summary>
namespace Algorithym.LeetCode
{

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
    /*C++实现*/
    /*
     class Solution {
    public:
        string addBinary(string a, string b) {
            string res;
            int p1 = a.size() - 1, p2 = b.size() - 1, x = 0, y = 0, carry = 0;
            while(p1 >= 0 || p2 >= 0)
            {
                x = p1 >= 0 ? a[p1--] - 48 : 0;
                y = p2 >= 0 ? b[p2--] - 48 : 0;
                int tmp = carry + x + y;
                res += tmp%2 + 48;
                carry = tmp>>1;
            }
            if(carry > 0) res += '1';
            reverse(res.begin(), res.end());
            return res;
        }
};
     */
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode
{
    public static class ReverseInteger
    {
        public static int Answer(int x)
        {
            int digit = 0;
            StringBuilder digitString = new StringBuilder();
            if (x < 0)
            {
                x = -x;
                digitString.Append("-");
            }
            while (x > 0)
            {
                digit = x % 10;
                digitString.Append(digit);
                x = x / 10;
            }

            int result = 0;
            int.TryParse(digitString.ToString(), out result);
            return result;
        }

        public static int AnswerV2(int x)
        {
            bool negative = (x < 0);
            int result = 0;
            int.TryParse((negative ? "-" : "") + new string(x.ToString().Remove(0, negative ? 1 : 0).Reverse().ToArray()), out result);
            return result;
        }

        public static int AnswerV3(int x)
        {
            int result = 0;

            StringBuilder output = new StringBuilder();
            string strData = x.ToString();
            for (int i = strData.Length - 1; i >= (x < 0 ? 1 : 0); i--)
            {
                output.Append(strData[i]);
            }

            int.TryParse((x < 0 ? "-" : "") + output.ToString(), out result);
            return result;
        }
    }
}

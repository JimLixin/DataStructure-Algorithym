using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.LeetCode.Topics
{
    public static class BitwiseCalculator
    {
        public static int Add(int x, int y)
        {
            int sum = x ^ y, carry = (x & y) << 1;

            while (carry != 0)
            {
                int a = sum;
                int b = carry;
                sum = a ^ b;
                carry = (a & b) << 1;
            }

            return sum;
        }

        public static int Substract(int x, int y)
        {
            int _y = Add(~y, 1);
            return Add(x, _y);
        }

        //        整理成算法步骤：

        //(1) 判断乘数是否为0，为0跳转至步骤(4)
        //(2) 将乘数与1作与运算，确定末尾位为1还是为0，如果为1，则相加数为当前被乘数；如果为0，则相加数为0；将相加数加到最终结果中；
        //(3) 被乘数左移一位，乘数右移一位；回到步骤(1)
        //(4) 确定符号位，输出结果；

        //代码如下：

        //int multiply(int a, int b)
        //        {
        //            //将乘数和被乘数都取绝对值　
        //            int multiplicand = a < 0 ? add(~a, 1) : a;
        //            int multiplier = b < 0 ? add(~b, 1) : b;

        //            //计算绝对值的乘积　　
        //            int product = 0;
        //            while (multiplier > 0)
        //            {
        //                if ((multiplier & 0x1) > 0)
        //                {// 每次考察乘数的最后一位　　　　
        //                    product = add(product, multiplicand);
        //                }
        //                multiplicand = multiplicand << 1;// 每运算一次，被乘数要左移一位　　　　
        //                multiplier = multiplier >> 1;// 每运算一次，乘数要右移一位（可对照上图理解）　　
        //            }
        //            //计算乘积的符号　　
        //            if ((a ^ b) < 0)
        //            {
        //                product = add(~product, 1);
        //            }
        //            return product;
        //        }


        //int divide_v2(int a, int b)
        //{
        //    // 先取被除数和除数的绝对值    
        //    int dividend = a > 0 ? a : add(~a, 1);
        //    int divisor = b > 0 ? a : add(~b, 1);
        //    int quotient = 0;// 商    
        //    int remainder = 0;// 余数    
        //    for (int i = 31; i >= 0; i--)
        //    {
        //        //比较dividend是否大于divisor的(1<<i)次方，不要将dividend与(divisor<<i)比较，而是用(dividend>>i)与divisor比较，
        //        //效果一样，但是可以避免因(divisor<<i)操作可能导致的溢出，如果溢出则会可能dividend本身小于divisor，但是溢出导致dividend大于divisor       
        //        if ((dividend >> i) >= divisor)
        //        {
        //            quotient = add(quotient, 1 << i);
        //            dividend = substract(dividend, divisor << i);
        //        }
        //    }
        //    // 确定商的符号    
        //    if ((a ^ b) < 0)
        //    {
        //        // 如果除数和被除数异号，则商为负数        
        //        quotient = add(~quotient, 1);
        //    }
        //    // 确定余数符号    
        //    remainder = b > 0 ? dividend : add(~dividend, 1);
        //    return quotient;// 返回商
        //}


    }
}
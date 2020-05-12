using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 134.加油站
/// https://leetcode-cn.com/problems/gas-station/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00134_gas_station
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total = 0, current = 0, index = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                total += gas[i] - cost[i];
                current += gas[i] - cost[i];
                if (current < 0)
                {
                    index = i + 1;
                    current = 0;
                }
            }
            return total >= 0 ? index : -1;
        }
    }
}

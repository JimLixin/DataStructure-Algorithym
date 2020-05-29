using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 874. 模拟行走机器人
/// https://leetcode-cn.com/problems/walking-robot-simulation/
/// </summary>
namespace Algorithym.LeetCode
{
    public class _00874_模拟行走机器人
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int x = 0, y = 0, dirIndex = 0, max = 0;
            HashSet<string> map = new HashSet<string>();
            for (int i = 0; i < obstacles.Length; i++)
                map.Add($"{obstacles[i][0]},{obstacles[i][1]}");
            int[][] dir = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == -2)
                    dirIndex = (dirIndex + 3) % 4;
                else if (commands[i] == -1)
                    dirIndex = (dirIndex + 1) % 4;
                else
                {
                    for (int j = 1; j <= commands[i]; j++)
                    {
                        int newX = x + dir[dirIndex][0];
                        int newY = y + dir[dirIndex][1];
                        if (map.Contains($"{newX},{newY}"))
                            break;
                        else
                        {
                            x = newX;
                            y = newY;
                            max = Math.Max(max, x * x + y * y);
                        }
                    }
                }
            }
            return max;
        }
    }
}

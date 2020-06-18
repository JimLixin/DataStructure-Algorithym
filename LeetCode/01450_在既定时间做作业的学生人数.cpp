﻿/*
1450. 在既定时间做作业的学生人数
https://leetcode-cn.com/problems/number-of-students-doing-homework-at-a-given-time/
*/
class Solution {
public:
    int busyStudent(vector<int>& startTime, vector<int>& endTime, int queryTime) {
        int res = 0;
        for (int i = 0; i < startTime.size(); i++)
        {
            if (queryTime >= startTime[i] && queryTime <= endTime[i])
            {
                //cout << "query:" << queryTime << ", start:" << startTime[i] << ", end:" << endTime[i] <<endl;
                res++;
            }

        }
        return res;
    }
};
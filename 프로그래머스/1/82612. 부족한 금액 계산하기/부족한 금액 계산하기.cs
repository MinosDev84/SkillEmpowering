using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long lmoney = money;
        
        for(int i = 1; i <= count; ++i)
        {
            lmoney -= (long)(price * i);
        }
        
        return (lmoney < 0) ? -lmoney : 0;
    }
}
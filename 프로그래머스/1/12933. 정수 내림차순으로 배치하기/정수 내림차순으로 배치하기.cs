using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        int[] tmp_n = new int[n.ToString().Length];        
        
        int max = 0;
        for(int i = 0; i < n.ToString().Length; ++i)
            tmp_n[i] = n.ToString()[i] - '0';
            
        Array.Sort(tmp_n);
        for(int i = tmp_n.Length - 1; i >= 0; --i)
        {
            long tmp_Digit = 1;
            for(int j = i - 1; j >= 0; --j)
                tmp_Digit *= 10;
            
            answer += (tmp_n[i] * tmp_Digit);
        }
            
        
        return answer;
    }
}
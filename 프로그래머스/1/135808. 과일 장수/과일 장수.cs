using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score);
        
        // 최대 이익 : 최하품을 최대한 한 박스로 몰아넣는다
        // 개수가 m으로 나누어떨어지지 않을 경우, 최상품부터 박스를 만든다
        for(int i = (score.Length - 1); i >= m - 1; i -= m)
        {
            int[] tmpBundle = new int[m];
            for(int j = i; j > i - m; --j)
                tmpBundle[i - j] = score[j];
            
            int min = k;
            for(int j = 0; j < tmpBundle.Length; ++j)
            {
                if(min > tmpBundle[j])
                    min = tmpBundle[j];
            }
            
            answer += min * m;    
        }
        
        return answer;
    }
}
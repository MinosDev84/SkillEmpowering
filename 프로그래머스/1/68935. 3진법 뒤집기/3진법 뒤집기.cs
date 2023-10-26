using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] tmp_n = new int[0];
        
        while(n > 0)
        {
            System.Array.Resize(ref tmp_n, tmp_n.Length + 1);
            tmp_n[tmp_n.Length - 1] = n % 3;
            n /= 3;
        }
        System.Array.Reverse(tmp_n);
        
        for(int i = 0; i < tmp_n.Length; ++i)
        {
            int tmp_Trinery = 1;
            for(int j = 0; j < i; ++j)
                tmp_Trinery *= 3;
            answer += tmp_n[i] * tmp_Trinery;
        }
        
        return answer;
    }
}
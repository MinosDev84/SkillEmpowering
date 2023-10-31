using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        answer[0] = -1;
        for(int i = 1; i < s.Length; ++i)
        {
            int j = i - 1;
            while(j >= 0 && s[j] != s[i])
                --j;
            
            if(j == -1)
                answer[i] = j;
            else
                answer[i] = i - j;
        }
        
        return answer;
    }
}
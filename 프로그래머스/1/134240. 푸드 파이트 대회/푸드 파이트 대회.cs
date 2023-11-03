using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for(int i = 1; i < food.Length; ++i)
        {
            for(int j = 0; j < food[i] / 2; ++j)
                answer += (char)(i + '0');
        }
        answer += '0';
        for(int i = food.Length - 1; i >= 1; --i)
        {
            for(int j = 0; j < food[i] / 2; ++j)
                answer += (char)(i + '0');
        }
        
        
        return answer;
    }
}
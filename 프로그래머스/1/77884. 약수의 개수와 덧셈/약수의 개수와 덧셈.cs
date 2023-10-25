using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        int squared = 0;
        for(int j = 0; j <= System.Math.Sqrt(right); ++j)
                squared += ((j * j >= left) && (j * j <= right)) ? (j * j) : 0;
        
        for(int i = left; i <= right; ++i)
            answer += i;
                
        return answer - (squared * 2);
    }
}
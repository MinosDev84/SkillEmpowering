using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        // 일단 left ~ right 전부 더한다
        for(int i = left; i <= right; ++i)
            answer += i;
        
        // 약수가 홀수이려면 제곱수여야 하므로, left ~ right 사이의 제곱수를 전부 더해둔다.
        int squared = 0;
        for(int j = 1; j <= System.Math.Sqrt(right); ++j)
                squared += ((j * j >= left) && (j * j <= right)) ? (j * j) : 0;   
                
        // left ~ right 전부 더한 값에서 제곱수들의 합을 2번 빼준다(이미 더해졌고 + 빼줘야하므로)
        return answer - (squared * 2);
    }
}
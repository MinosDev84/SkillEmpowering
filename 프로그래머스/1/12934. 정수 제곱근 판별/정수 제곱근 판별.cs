public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        long i = 0;
        while(i < 7071068)
        {
            if(i * i == n)
            {
                answer = (i + 1) * (i + 1);
                i = 7071068;
            }
            else
            {
                answer = -1;
                ++i;
            }
        }
        
        return answer;
    }
}
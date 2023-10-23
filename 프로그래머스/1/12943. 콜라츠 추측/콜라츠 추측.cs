public class Solution {
    public int solution(int num) {
        int answer = 0;
        
        if(num == 1)
            answer = 0;
        else
        {
            long tmp = num;
            while(answer <= 500 && tmp != 1)
            {
                ++answer;
                tmp = (tmp % 2 == 0) ? tmp / 2 : (tmp * 3) + 1;
            }
            if(tmp != 1)
                answer = -1;
        }
        
        return answer;
    }
}
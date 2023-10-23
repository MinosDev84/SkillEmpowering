public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int tmp_x = x;
        int tmp_Sum = 0;
        
        while(tmp_x > 0)
        {
            tmp_Sum += tmp_x % 10;
            tmp_x /= 10;
        }
        
        if(x % tmp_Sum == 0)
            answer = true;
        
        return answer;
    }
}
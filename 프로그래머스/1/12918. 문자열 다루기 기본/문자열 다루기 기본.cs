public class Solution {
    public bool solution(string s) {
        int integer = -1;
        bool answer = true;
        
        if(s.Length != 4 && s.Length != 6)
            answer = false;
        for(int i = 0; i < s.Length; ++i)
            if(s[i] < '0' || s[i] > '9')
                answer = false;
        
        return answer;
    }
}
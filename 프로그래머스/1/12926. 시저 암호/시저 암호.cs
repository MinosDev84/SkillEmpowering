public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0; i < s.Length; ++i)
        {
            char tmp = ' ';
            if(s[i] != ' ')
            {
                if(s[i] >= 'A' && s[i] <= 'Z')
                {
                    tmp = (char)(s[i] + n);
                    if(tmp > 'Z')
                        tmp -= (char)26;
                }
                else if(s[i] >= 'a' && s[i] <= 'z')
                {
                    tmp = (char)(s[i] + n);
                    if(tmp > 'z')
                        tmp -= (char)26;
                }
            }
            else
                tmp = (char)s[i];
            
            answer += tmp;
        }
        
        return answer;
    }
}
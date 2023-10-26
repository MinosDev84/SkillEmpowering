using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        ulong num_P = ulong.Parse(p);
        
        for(int i = 0; i < t.Length - (p.Length - 1); ++i)
        {
            string partial_t = "";
            for(int j = i; j < i + p.Length; ++j)
                partial_t += t[j];

            if(ulong.Parse(partial_t) <= num_P)
                ++answer;
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        
        int tmp_total = 0;
        int i = 0;
        while((tmp_total < budget) && (i < d.Length))
        {
            tmp_total += d[i];
            ++answer;
            ++i;
        }
        
        answer = (tmp_total <= budget) ? answer * 1 : answer - 1;
        
        return answer;
    }
}
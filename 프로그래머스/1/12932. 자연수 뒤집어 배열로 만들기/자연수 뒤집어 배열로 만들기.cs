public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[n.ToString().Length];
        
        for(int i = 0; i < n.ToString().Length; ++i)
            answer[i] = n.ToString()[n.ToString().Length - i - 1] - '0';
        
        return answer;
    }
}
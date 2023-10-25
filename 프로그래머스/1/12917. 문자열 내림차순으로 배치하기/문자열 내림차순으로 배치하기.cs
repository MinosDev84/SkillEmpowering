public class Solution {
    public string solution(string s) {
        char[] tmp_answer = new char[] {};
        
        tmp_answer = s.ToCharArray(0, s.Length);
        System.Array.Sort(tmp_answer);
        System.Array.Reverse(tmp_answer);
        
        return new string(tmp_answer);
    }
}
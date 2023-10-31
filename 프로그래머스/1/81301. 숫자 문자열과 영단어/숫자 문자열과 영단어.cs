using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string tmp_answer = s;
        
        tmp_answer = tmp_answer.Replace("zero", "0");
        tmp_answer = tmp_answer.Replace("one", "1");
        tmp_answer = tmp_answer.Replace("two", "2");
        tmp_answer = tmp_answer.Replace("three", "3");
        tmp_answer = tmp_answer.Replace("four", "4");
        tmp_answer = tmp_answer.Replace("five", "5");
        tmp_answer = tmp_answer.Replace("six", "6");
        tmp_answer = tmp_answer.Replace("seven", "7");
        tmp_answer = tmp_answer.Replace("eight", "8");
        tmp_answer = tmp_answer.Replace("nine", "9");
        
        int.TryParse(tmp_answer, out answer);
        
        return answer;
    }
}
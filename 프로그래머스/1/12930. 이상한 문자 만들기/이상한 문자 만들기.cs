public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] splited_s = s.Split(' ');
        string[] tmp_answer = new string[splited_s.Length];
        
        // 단어 배열을 만들어, 짝수 번째 알파벳을 대문자로 바꾸고, 각 단어 뒤에 띄어쓰기를 붙인다.
        for(int i = 0; i < splited_s.Length; ++i)
        {
            for(int j = 0; j < splited_s[i].Length; ++j)
                tmp_answer[i] += (j % 2 == 0) ? System.Char.ToUpper(splited_s[i][j]) : System.Char.ToLower(splited_s[i][j]);
            tmp_answer[i] += ' ';
        }
        
        // answer에 단어 배열을 추가하고, 맨 뒤에 붙은 띄어쓰기를 지워준다.
        for(int i = 0; i < tmp_answer.Length; ++i)
            answer += tmp_answer[i];
        answer = answer.Remove(answer.Length - 1);
        
        return answer;
    }
}
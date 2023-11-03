public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        char[] indexs = new char[strings.Length];
        
        // indexs에 인덱스 n번째 알파벳을 저장
        for(int i = 0; i < strings.Length; ++i)
            indexs[i] = strings[i][n];
        // indexs를 오름차순 정렬
        System.Array.Sort(indexs); // c c x
        System.Array.Sort(strings);
        
        // 각 indexs 글자가 strings의 n번째 자리와 일치하면 answer에 저장
        for(int i = 0; i < indexs.Length; ++i)
        {
            bool charFound = false;
            for(int j = 0; j < strings.Length; ++j)
            {
                if(strings[j][n] == indexs[i] && !charFound)
                {
                    answer[i] = strings[j];
                    strings[j] = "????????????????????????????????????????????????????????????????????????????????????????????????????";
                    charFound = true;
                }
            }
        }
        
        return answer;
    }
}
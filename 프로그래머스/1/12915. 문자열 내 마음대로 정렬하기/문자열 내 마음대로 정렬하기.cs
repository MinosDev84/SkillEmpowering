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
                    // 중복을 방지하기 위해 이미 찾은 문자열은 제한 조건에 맞지 않게 만든다
                    // 런타임 에러가 났던 부분으로, 길이는 최대 길이로 유지해준다.
                    // 실행 시간이 길어지는 부분이 흠
                    strings[j] = "????????????????????????????????????????????????????????????????????????????????????????????????????";
                    charFound = true;
                }
            }
        }
        
        return answer;
    }
}
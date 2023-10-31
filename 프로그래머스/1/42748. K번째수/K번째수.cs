using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {        
        int[] answer = new int[commands.GetLength(0)];
        
        // commands 갯수만큼 반복
        for(int i = 0; i < answer.Length; ++i)
        {
            int[] tmpArray = new int[0];
            int count = 0;
            // Step 1 : 배열에서, 각 commands의 (1원소)번째 부터 (2원소)번째까지 자르기
            for(int j = (commands[i, 0] - 1); j < commands[i, 1]; ++j)
            {
                Array.Resize(ref tmpArray, tmpArray.Length + 1);
                tmpArray[tmpArray.Length - 1] = array[j];
            }
            // Step 2 : Step 1의 결과물을 반복
            Array.Sort(tmpArray);
            
            // Step 3 : commands의 (3원소)번째에 있는 숫자를 답 배열에 입력
            answer[i] = tmpArray[(commands[i, 2] - 1)];
        }
            
        return answer;
    }
}
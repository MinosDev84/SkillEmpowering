using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        
        for(int i = 0; i < numbers.Length - 1; ++i)
        {
            for(int j = i + 1; j < numbers.Length; ++j)
            {
                // 현재 두 수의 합이 answer에 없을 경우, answer를 한 칸 늘리고 그 합을 입력
                if(Array.IndexOf(answer, (numbers[i] + numbers[j])) == -1)
                {
                    Array.Resize(ref answer, answer.Length + 1);
                    answer[answer.Length - 1] = numbers[i] + numbers[j];
                }
            }
        }
        
        Array.Sort(answer);
        
        return answer;
    }
}
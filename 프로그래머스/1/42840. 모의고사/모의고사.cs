using System;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        int[] tmpAnswer = new int[] { 0, 0, 0 };
        int[] tmpDice2 = new int[] { 1, 3, 4, 5 };
        int[] tmpDice3 = new int[] { 3, 1, 2, 4, 5 };
        
        // Step 1 : 규칙 찾기
        for(int i = 0; i < answers.Length; ++i)
        {
            int dice1 = (i % 5) + 1;
            int dice2 = (i % 2 == 0) ? 2 : (tmpDice2[(((i - 1) % 8) / 2)]);
            int dice3 = tmpDice3[(i % 10) / 2];
            
            if(answers[i] == dice1)
                tmpAnswer[0] += 1;
            if(answers[i] == dice2)
                tmpAnswer[1] += 1;
            if(answers[i] == dice3)
                tmpAnswer[2] += 1;
        }
        
        // Step 2 : 가장 많이 맞춘 값 찾기
        int max = 0;
        for(int i = 0; i < tmpAnswer.Length; ++i)
            if(max < tmpAnswer[i])
                max = tmpAnswer[i];
                
        // Step 3 : 가장 많이 맞춘 사람 찾기
        for(int i = 0; i < tmpAnswer.Length; ++i)
        {
            if(max == tmpAnswer[i])
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = i + 1;
            }
        }
        
        return answer;
    }
}
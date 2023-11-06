using System;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        int[] tmpArray = new int[0];
        
        for(int i = 0; i < score.Length; ++i)
        {
            Array.Resize(ref tmpArray, tmpArray.Length + 1);
            tmpArray[i] = score[i];
            Array.Sort(tmpArray); 
            if(i < k)
                answer[i] = tmpArray[0];
            else
                answer[i] = tmpArray[tmpArray.Length - k];
        }
        
        return answer;
    }
}
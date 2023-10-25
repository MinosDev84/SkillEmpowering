public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        int min = 20001;
        for(int i = 0; i < arr.Length; ++i)
            if(min > arr[i])
                min = arr[i];
        
        for(int i = 0; i < arr.Length; ++i)
        {
            if(arr[i] != min)
            {
                System.Array.Resize(ref answer, answer.Length + 1);
                answer.SetValue(arr[i], answer.Length - 1);
            }
        }
        
        if(answer.Length == 0)
        {
            System.Array.Resize(ref answer, answer.Length + 1);
            answer.SetValue(-1, answer.Length - 1);
        }
        
        return answer;
    }
}
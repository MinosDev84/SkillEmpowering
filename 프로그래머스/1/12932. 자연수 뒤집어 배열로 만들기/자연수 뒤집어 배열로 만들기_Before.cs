public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[0];

        int i = 0;
        while(n > 0)
        {
            long tmp = n % 10;
            // answer에 tmp 쓰기
            int[] tmp_Array = new int[answer.Length + 1];
            answer.CopyTo(tmp_Array, 0);
            tmp_Array[i] = (int)tmp;
            answer = tmp_Array;
            n /= 10;
            ++i;
        }

        return answer;
    }
}

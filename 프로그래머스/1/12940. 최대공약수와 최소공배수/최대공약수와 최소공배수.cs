public class Solution {
    public int[] solution(int n, int m) {
        int largest = 0;
        int smallest = 1000001;
        
        if(n > m)
        {
            int tmp = n;
            n = m;
            m = tmp;
        }
        
        for(int i = 1; i <= n; ++i)
            if(m % i == 0 && n % i == 0)
                largest = i;
        
        smallest = m * n / largest;
        
        int [] answer = new int[] {largest, smallest};
        
        return answer;
    }
}
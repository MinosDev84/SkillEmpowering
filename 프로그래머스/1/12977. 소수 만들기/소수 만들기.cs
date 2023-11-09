using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        // 조합 문제
        // Step 1 : 숫자 3개를 고르고 더한다
        for(int i = 0; i < nums.Length - 2; ++i)
        {
            int tmpSum = 0;
            for(int j = i + 1; j < nums.Length - 1; ++j)
            {
                for(int k = j + 1; k < nums.Length; ++k)
                {
                    tmpSum = nums[i] + nums[j] + nums[k];
                    
                    // Step 2 : 합이 소수인지 판별한다
                    int check = 0;
                    for(int l = 1; l <= tmpSum; ++l)
                        if(tmpSum % l == 0)
                            ++check;
                            
                    if(check == 2)
                        ++answer;
                }
            }
        }

        return answer;
    }
}
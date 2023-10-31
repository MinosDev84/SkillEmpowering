using System;

public class Solution {
    public int solution(int[,] sizes) {
        for(int i = 0; i < sizes.GetLength(0); ++i)
        {
            if(sizes[i, 0] < sizes[i, 1])
            {
                int tmp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = tmp;
            }
        }
        
        int maxWidth = 0, maxHeight = 0;
        for(int i = 0; i < sizes.GetLength(0); ++i)
        {
            if(maxWidth < sizes[i, 0])
                maxWidth = sizes[i, 0];
            if(maxHeight < sizes[i, 1])
                maxHeight = sizes[i, 1];
        }
        
        return maxWidth * maxHeight;
    }
}
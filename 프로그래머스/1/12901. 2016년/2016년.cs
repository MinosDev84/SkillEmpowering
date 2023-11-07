public class Solution {
    public string solution(int a, int b) {
        int[] index = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        string[] days = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        int totalDays = 0;
        
        // 31일 : 1, 3, 5, 7, 8, 10, 12
        // 30일 : 4, 6, 9, 11
        // 29일 : 2
        if(a == 1)
            totalDays = b - 1;
        else
        {
            for(int i = 2; i <= a; ++i)
            {
                if(i == 2 || i == 4 || i == 6 || i == 8 || i == 9 || i == 11)
                    totalDays += 31;
                else if(i == 5 || i == 7 || i == 10 || i == 12)
                    totalDays += 30;
                else if(i == 3)
                    totalDays += 29;
            }
            
            totalDays += b - 1;
        }
        
        return days[totalDays % 7];
    }
}
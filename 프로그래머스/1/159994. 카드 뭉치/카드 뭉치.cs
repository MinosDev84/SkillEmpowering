public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        string answer = "";
        int indexCard1 = 0, indexCard2 = 0;
        
        foreach(string s in goal)
        {
            if(indexCard1 < cards1.Length && s == cards1[indexCard1])
                ++indexCard1;
            else if(indexCard2 < cards2.Length && s == cards2[indexCard2])
                ++indexCard2;
            else
                return "No";
        }
        
        return "Yes";
    }
}
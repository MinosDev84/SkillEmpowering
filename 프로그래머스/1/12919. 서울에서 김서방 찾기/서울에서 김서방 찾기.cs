public class Solution {
    public string solution(string[] seoul) {
        int location = -1;
        for(int i = 0; i < seoul.Length; ++i)
            if(seoul[i] == "Kim")
                location = i;
        
        return "김서방은 " + location + "에 있다";
    }
}
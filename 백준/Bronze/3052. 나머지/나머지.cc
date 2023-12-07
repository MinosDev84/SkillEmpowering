#include <iostream>

using namespace std;

int main()
{
    ios_base :: sync_with_stdio(false); 
    cin.tie(NULL); 
    
    // Make remains array
    int inputs[10];
    for(int i = 0; i < 10; ++i)
    {
        cin >> inputs[i];
        inputs[i] %= 42;
    }
    
    // if same remain occurs,
    // make it -1
    for(int i = 0; i < 10; ++i)
    {
        for(int j = i + 1; j < 10; ++j)
        {
            if(inputs[j] == inputs[i])
                inputs[j] = -1;
        }
    }
        
    // count which is not -1
    int answer = 0;
    for(int i = 0; i < 10; ++i)
    {
        if(inputs[i] != -1)
            ++answer;
    }
    
    cout << answer << '\n';
    
    return 0;
}
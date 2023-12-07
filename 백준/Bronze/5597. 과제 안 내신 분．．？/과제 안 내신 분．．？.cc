#include <iostream>

using namespace std;

int main()
{
    ios_base :: sync_with_stdio(false); 
    cin.tie(NULL); 
    
    bool isFinished = false;
    int num[30];
    int submitted = 0;
    
    // Make student array
    for(int i = 0; i < 30; ++i)
        num[i] = i + 1;
        
    while(!isFinished)
    {
        if(cin.eof())
            isFinished = true;
        else
        {
            // Delete submitted student
            cin >> submitted;
            num[submitted - 1] = 0;
        }
    }
    
    for(int i = 0; i < 30; ++i)
        if(num[i] != 0)
            cout << num[i] << '\n';
    
    return 0;
}
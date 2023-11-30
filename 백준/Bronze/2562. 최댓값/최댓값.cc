#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false); 
    cin.tie(NULL);
    
    int num[9];
    for(int i = 0; i < 9; ++i)
        cin >> num[i];
        
    int max = 0, index;
    for(int i = 0; i < 9; ++i)
        if(num[i] > max)
        {
            max = num[i];
            index = i + 1;
        }
        
    cout << max << '\n';
    cout << index << '\n';
    
    return 0;
}
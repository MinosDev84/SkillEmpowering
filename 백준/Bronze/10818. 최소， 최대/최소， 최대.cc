#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false); 
    cin.tie(NULL);
    
    int n;
    cin >> n;
    int num[n];
    for(int i = 0; i < n; ++i)
        cin >> num[i];
        
    int min = 1000001, max = -1000001;
    for(int i = 0; i < n; ++i)
    {
        if(num[i] < min)
            min = num[i];
        if(num[i] > max)
            max = num[i];
    }
        
    cout << min << ' ' << max << '\n';
    
    return 0;
}
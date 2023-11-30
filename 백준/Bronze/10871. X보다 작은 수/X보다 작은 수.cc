#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false); 
    cin.tie(NULL);
    
    int n, x;
    cin >> n >> x;
    int num[n];
    for(int i = 0; i < n; ++i)
        cin >> num[i];
        
    for(int i = 0; i < n; ++i)
        if(num[i] < x)
            cout << num[i] << ' ';
    
    return 0;
}
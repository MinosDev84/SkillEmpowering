#include <iostream>

using namespace std;

int main()
{
    cin.tie(NULL);
    ios_base::sync_with_stdio(false);
    
    int n;
    cin >> n;
    
    for(int i = 1; i <= n; ++i)
    {
        string tmp;
        for(int j = 0; j < i; ++j)
            tmp += '*';
            
        cout << tmp << "\n";
    }
    
    return 0;
}
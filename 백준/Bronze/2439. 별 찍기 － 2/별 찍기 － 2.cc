#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false); 
    cin.tie(NULL);
    
    int n;
    cin >> n;
    
    for(int i = 0; i < n; ++i)
    {
        string tmp;
        for(int j = (n - 1) - i; j > 0; --j)
            tmp += ' ';
        for(int j = 0; j <= i; ++j)
            tmp += '*';
        cout << tmp << "\n";
    }
    
    return 0;
}
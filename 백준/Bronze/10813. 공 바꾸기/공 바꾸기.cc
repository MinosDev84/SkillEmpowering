#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio (false);
    cin.tie (NULL);
    
    // n : Make No.1 ~ N basket
    // m : Decide how many times steps repeated
    int n, m;
    cin >> n >> m;
    int basket[n];
    for(int i = 0; i < n; ++i)
        basket[i] = i + 1;
    
    // Repeat exchanging m times
    for(int i = 0; i < m; ++i)
    {
        int a, b;
        cin >> a >> b;
        // Exchange : a, b is natural num(over 0)
        // So make a, b to index in C++ lang
        int tmp = basket[a - 1];
        basket[a - 1] = basket[b - 1];
        basket[b - 1] = tmp;
    }
    
    // Output
    for(int i = 0; i < n; ++i)
        cout << basket[i] << ' ';

    return 0;
}
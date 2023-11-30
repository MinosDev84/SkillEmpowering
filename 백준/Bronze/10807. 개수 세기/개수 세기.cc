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
        
    int v, count;
    cin >> v;
    
    for(int i = 0; i < n; ++i)
        if(num[i] == v)
            ++count;
            
    cout << count << "\n";
    
    return 0;
}
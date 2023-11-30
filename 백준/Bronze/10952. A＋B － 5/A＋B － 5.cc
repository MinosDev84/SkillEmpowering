#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false); 
    cin.tie(NULL);
    
    int a, b;
    bool isFinished = false;
    while(!isFinished)
    {
        cin >> a >> b;
        if(a == b && b == 0)
            isFinished = true;
        else
            cout << a + b << "\n";
    }
    
    return 0;
}
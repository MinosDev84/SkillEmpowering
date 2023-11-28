#include <iostream>

using namespace std;

int main()
{
    int total, bought;
    cin >> total;
    cin >> bought;
    
    for(int i = 0; i < bought; ++i)
    {
        int price, each;
        cin >> price >> each;
        total -= (price * each);
    }
    
    cout << (total == 0 ? "Yes" : "No") << endl;
    
    return 0;
}
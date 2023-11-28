#include <iostream>

using namespace std;

int main()
{
    double a, b;
    double result;
    
    cin >> a >> b;
    result = a / b;
    cout.precision(15);
    cout << result << endl;
    
    return 0;
}

#include <iostream>

using namespace std;

int main()
{
    int a, b, c;
    int finishH, finishM;
    
    cin >> a >> b;
    cin >> c;
    
    finishH = a + ((b + c) / 60);
    if(finishH > 23)
        finishH %= 24;
    finishM = (b + c) % 60;
    
    cout << finishH << " " << finishM << endl;

    return 0;
}
#include <iostream>

using namespace std;

int main()
{
    int dice[3];
    int result;
    
    cin >> dice[0] >> dice[1] >> dice[2];
    
    // rule 1
    if(dice[0] == dice[1] && dice[1] == dice[2])
        result = 10000 + dice[0] * 1000;
    // rule 2, 3
    else
    {
        // rule 3
        if(dice[0] != dice[1] && dice[1] != dice[2] && dice[0] != dice[2])
        {
            int max = 0;
            for(int i = 0; i < size(dice); ++i)
            {
                if(max < dice[i])
                    max = dice[i];
            }
            result = max * 100;
        }
        // rule 2
        else
            result = 1000 + ((dice[0] == dice[1]) ? dice[0] : dice[2]) * 100;
    }
        
    cout << result << endl;

    return 0;
}
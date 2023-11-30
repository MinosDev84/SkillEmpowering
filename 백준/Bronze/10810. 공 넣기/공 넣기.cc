#include <iostream>

using namespace std;

int main()
{
  ios_base::sync_with_stdio (false);
  cin.tie (NULL);

  int n, m;
  cin >> n >> m;
  int basket[n];
  for(int i = 0; i < n; ++i)
    basket[i] = 0;
  
  for(int i = 0; i < m; ++i)
  {
      int a, b, c;
      cin >> a >> b >> c;
      for(int j = a - 1; j < b; ++j)
          basket[j] = c;
  }
  
  for(int i = 0; i < n; ++i)
    cout << basket[i] << ' ';

  return 0;
}
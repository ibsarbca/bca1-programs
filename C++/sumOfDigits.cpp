#include <iostream>
using namespace std;
int main()
{
  int sum = 0, num = 0;
  cout << "Please enter a number:" << "\n";
  cin >> num;
  for (num = 0; num != 0; num = num / 10)
  {
    sum = sum + num % 10;
  }
  cout << sum;
}

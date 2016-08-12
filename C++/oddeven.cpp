#include <iostream>

using namespace std;

int main()
{
    int num;
    cout << "Please enter a number: ";
    cin >> num;
    if ((num % 2) == 0)
        cout << "Num is even";
    else
        cout << "Num is odd";
}

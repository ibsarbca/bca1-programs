#include <iostream>

using namespace std;

int main()
{
    int num1;
    cout << "Please enter a number: ";
    cin >> num1;
    int num2;
    cout << "Please enter a second number: ";
    cin >> num2;
    if (num1 > num2)
        cout << "Num1 is greater and num2 is smaller";
    else
        cout << "Num2 is greater and num1 is smaller";
}

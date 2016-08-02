#include <iostream>
using namespace std;
int main()
{
    int a = 5;
    int b = 20;

    if (a && b)
        cout << " a && b is true";
    else
        cout << " a && b is false";

    if (a || b)
        cout << " a || b is true";
    else
        cout << " a || b is false";
}

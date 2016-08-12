#include <iostream>

using namespace std;
int main()
{
    cout << "Please enter your name: ";
    char name[20];
    cin >> name;
    cout << "Please enter your age: ";
    int age;
    cin >> age;
    cout << "Welcome " << name << " your age is " << age;

    return 0;
}

#include <iostream>
#include <string>

using namespace std;
int main()
{
    int marks;
    cout << "Enter marks: ";
    cin >> marks;
    string grade;
    if (marks <= 35)
        grade = "You have failed";
    if (marks > 35 && marks <= 65)
        grade = "You have scored second class";
    if (marks > 65 && marks <= 75)
        grade = "You have scored first class";
    if (marks >= 75)
        grade = "You have scored distinction";

    cout << grade;
}

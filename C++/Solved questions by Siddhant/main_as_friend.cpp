#include<iostream>
using namespace std;
class A
{
    int a=1,b=2;
public:
  friend int main(int ,char**);

};
int main(int ,char**)
{
    A obj;
    cout<<"Addition="<<obj.a+obj.b;
}
/*In this program we are declaring the main function as friend function so we can directly access the
any members of that class in main()*/

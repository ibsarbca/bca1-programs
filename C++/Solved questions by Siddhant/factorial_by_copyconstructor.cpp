#include<iostream>
using namespace std;
class Fact
{
    public:
    int temp;
    int i;
    int f=1;
    Fact(int t)
    {
        temp=t;
    }
    Fact(Fact &ob)
    {

        temp=ob.temp;

        for(i=1;i<=5;i++)
        {
            f=f*i;
        }

    }
    Fact(Fact &ob,Fact &ob2)
    {
        f=ob.f;
        temp=ob2.temp;
        cout<<"Factorial of "<<temp<<"="<<f;
    }

};
int main()
{
    Fact obj1(5);
    Fact obj2(obj1);
    Fact obj3(obj2,obj1);
}

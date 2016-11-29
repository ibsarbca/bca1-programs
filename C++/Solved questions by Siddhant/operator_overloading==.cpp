#include<iostream>
using namespace std;
class A
{
    public:
        int a;
        void get()
        {
            cout<<"Enter any number:"<<endl;
            cin>>a;
        }
        A operator ==(const A &c)
        {
            A b;
            if(a==c.a)
            {
                cout<<" is equal"<<endl;
            }
            else
            {
                cout<<" is not equal "<<endl;
            }
        }

        public:
        void Display()

        {
            cout<<a<<endl;
        }
};
int main()
{
    A x,y,z;
    x.get();
    y.get();
    x==y;

}

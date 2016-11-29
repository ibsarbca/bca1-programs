#include<iostream>
using namespace std;
int main()
{
    int n,i,f=0;
    cout<<"Enter the number:";
    cin>>n;
    for(i=2;i<=n/2;i++)
    {
        if(n%i==0)
        {
            f=1;
            break;
        }
    }
    if(f==0)
    {
        cout<<"This is prime number";
    }
    else
    {
        cout<<"This is not prime number";
    }
}

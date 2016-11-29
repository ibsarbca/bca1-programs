#include<iostream>
using namespace std;
int main()
{
    int num,first,second,sum=0,i;
    first=0,second=1;
    cout<<"Enter the number:";
    cin>>num;
    for(i=1;i<=num;i++)
    {
        cout<<first<<"\t";
        sum=first+second;
        first=second;
        second=sum;
    }
}

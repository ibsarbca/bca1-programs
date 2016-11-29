#include<iostream>
using namespace std;
class patt{
    public:
    patt()
    {
        int num=1,i,j;
        for(i=1;i<5;i++)
        {
            for(j=1;j<=i;j++)
            {
                cout<<num;
                num++;
            }
            cout<<endl;
        }
    }
};

int main()
{
    patt obj;
}

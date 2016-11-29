#include<iostream>
using namespace std;
class a
{
    public:
        inline int max(int a,int b,int c)
        {
            if(a>b)
            {
                if(a>c)
                {
                    return a;
                }

            else{
                return c;
            }
            }
            else{
                if(b>c)
                {
                    return b;
                }
                else {
                    return c;
                }
            }

        }
};
int main()
{
    a obj;
    cout<<obj.max(3,4,1);
}

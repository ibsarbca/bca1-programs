#include<iostream>
using namespace std;
class Oper
{
private:
    int count;
public:
    Oper():count(1){}
    void operator ++()//overloading ++ operator
    {
        count=count+2;//Incrementing value by two
    }
    void display()
    {
        cout<<"Count:"<<count;
    }
};
int main()
{
    Oper obj;
    ++obj;
    obj.display();
}

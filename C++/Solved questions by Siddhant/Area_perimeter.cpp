#include<iostream>
using namespace std;
class shape
{
    public:
        int side,l,h;
        int input()
        {
            cout<<"Enter side of square";
            cin>>side;
            cout<<"Enter length,height of triangle";
            cin>>l>>h;
            return side;
        }

};
class Square:public shape
{
    public:

        int area()
        {
            input();
            cout<<"Area of square:";
            cout<<side*side<<endl;
        }
        int perimeter()
        {
            cout<<"Perimeter of square";
            cout<<4*side<<endl;
        }
};
class triangle:public Square
{
    public:
        int area_t()
        {
            cout<<"Area of triangle";
            cout<<1/2*l*h;
        }
};
int main()
{
    triangle obj;
    obj.area();
    obj.perimeter();
    obj.area_t();

}

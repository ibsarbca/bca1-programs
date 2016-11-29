#include<iostream>
#include<conio.h>

using namespace std;

float interest(float p,float t,float r){ return((p*t*r)/100);}

int main(){
 float p,t,r;
 cout<<"Principle = ";cin>>p;
 cout<<"Time = ";cin>>t;
 cout<<"Rate = ";cin>>r;
 cout<<"Simple Interest = "<<interest(p,t,r);
 getch();
 return(0);
}

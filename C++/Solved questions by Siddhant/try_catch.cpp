#include<iostream>
using namespace std;

void  division(int a, int b) {
   if( b == 0 ) {
      throw "Division";
   }
   cout<<(a/b);
}

int main () {
   int x = 50;
   int y = 0;

   try
   {
      division(x, y);

   }
   catch (const char*msg)
   {
      cout<<msg;
   }
}

#include <iostream>
using namespace std;

class A {
   private:
      int num1;
      int num2;
   public:

      A(){
         num1 = 0;
         num2 = 0;
      }
      A(int n1, int n2){
         num1 = n1;
            num2= n2;
      }
      friend ostream &operator<<( ostream &output, const A &obj ) {

         output << "Number1 : " << obj.num1 << " number2 : " << obj.num2;

         return output;
      }

      friend istream &operator>>( istream  &input, A &obj )
      {
          input >> obj.num1 >> obj.num2;

         return input;
      }
};

int main() {

    A obj1;

   cout << "Enter the value of number : " << endl;
   cin >> obj1;
   cout << "Values:" << obj1 << endl;

return 0;
}

#include<iostream>
#include<fstream>
#include<string.h>
using namespace std;
int main()
{
    char data[100],data1[100];
    ofstream file_var1;
    file_var1.open("E:\\text1.txt");
    cout<<"Writing to the file";
    cout<<"Enter Item Code:";
    cin.getline(data,100);
    cout<<"Enter Cost:";
    cin.getline(data1,100);

    file_var1<<"Item Code"<<data<<endl;
    file_var1<<"cost:"<<data1<<endl;
    file_var1.close();


}

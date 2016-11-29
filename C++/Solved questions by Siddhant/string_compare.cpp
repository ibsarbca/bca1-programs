#include<iostream>
#include<string.h>
using namespace std;
int main()
{
    int a;
	char str1[100], str2[100];
	cout<<"Enter first string : ";
	cin>>str1;
	cout<<"Enter second string : ";
	cin>>str2;
	a=strcmp(str1, str2);
	if(a==0)
	{
		cout<<"Both the strings are equal";
	}
	else
	{
		cout<<"Both the strings are not equal";
	}
}
